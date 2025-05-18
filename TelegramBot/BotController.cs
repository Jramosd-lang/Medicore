using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Requests;
using TelegramBot.Interfaces;

namespace TelegramBot
{
    public class BotController
    {
        private readonly ITelegramBotClient _bot;
        private readonly IPacienteService _pacienteSvc;
        private readonly IDoctorService _doctorSvc;
        private readonly IHistorialService _historialSvc;

        public BotController(
            ITelegramBotClient bot,
            IPacienteService pacienteSvc,
            IDoctorService doctorSvc,
            IHistorialService historialSvc)
        {
            _bot = bot;
            _pacienteSvc = pacienteSvc;
            _doctorSvc = doctorSvc;
            _historialSvc = historialSvc;
        }

        public async Task HandleUpdateAsync(
            ITelegramBotClient botClient,
            Update update,
            CancellationToken ct)
        {
            if (update.Message?.Text != null)
            {
                await HandleMessageAsync(update.Message);
            }
            else if (update.CallbackQuery != null)
            {
                await HandleCallbackAsync(update.CallbackQuery);
            }
        }

        public Task HandleErrorAsync(
            ITelegramBotClient botClient,
            Exception ex,
            CancellationToken ct)
        {
            Console.WriteLine($"[Error] {ex.Message}");
            return Task.CompletedTask;
        }

        private async Task HandleMessageAsync(Message msg)
        {
            var chatId = msg.Chat.Id;
            var text = msg.Text.Trim();

            // Si el texto es un número, intentamos buscar el paciente
            if (int.TryParse(text, out _))
            {
                var paciente = await _pacienteSvc.GetByDocumentoAsync(text);

                if (paciente == null)
                {
                    await _bot.SendRequest(new SendMessageRequest
                    {
                        ChatId = chatId,
                        Text = "No se encontró paciente."
                    });
                    return;
                }
                else
                {
                    await MostrarMenuPrincipal(chatId, paciente);
                    return;
                }
            }

            // Para cualquier otro texto, responde siempre con la bienvenida y petición de ID
            await _bot.SendRequest(new SendMessageRequest
            {
                ChatId = chatId,
                Text = "Bienvenido a MediCore.\nIngresa tu ID (número de documento):"
            });
        }

        private async Task HandleCallbackAsync(Telegram.Bot.Types.CallbackQuery query)
        {
            var chatId = query.Message.Chat.Id;
            var parts = query.Data.Split('|');
            var action = parts[0];
            var documento = parts.Length > 1 ? parts[1] : "";

            switch (action)
            {
                case "historial":
                    var url = await _historialSvc.GetHistorialPdfUrl(documento);
                    await _bot.SendRequest(new SendMessageRequest
                    {
                        ChatId = chatId,
                        Text = $"Tu historial: {url}"
                    });
                    break;

                case "doctor":
                    var doc = await _doctorSvc.GetDoctorByPacienteDocumento(documento);
                    await _bot.SendRequest(new SendMessageRequest
                    {
                        ChatId = chatId,
                        Text = doc != null ? $"Tu doctor: {doc}" : "Doctor no asignado"
                    });
                    break;

                case "citas":
                    await _bot.SendRequest(new SendMessageRequest
                    {
                        ChatId = chatId,
                        Text = "🔔 Próximamente podrás ver y gestionar tus citas desde aquí."
                    });
                    break;

                case "actualizar":
                    await _bot.SendRequest(new SendMessageRequest
                    {
                        ChatId = chatId,
                        Text = "Para actualizar tus datos, por favor comunícate con la recepción del consultorio."
                    });
                    break;

                case "ayuda":
                    await _bot.SendRequest(new SendMessageRequest
                    {
                        ChatId = chatId,
                        Text = "Si tienes dudas, puedes escribirnos a: soporte@medicore.com o llamar al 3106933004."
                    });
                    break;

                case "volver":
                    // Buscar de nuevo el paciente para mostrar el menú principal
                    var paciente = await _pacienteSvc.GetByDocumentoAsync(documento);
                    if (paciente != null)
                    {
                        await MostrarMenuPrincipal(chatId, paciente);
                    }
                    else
                    {
                        await _bot.SendRequest(new SendMessageRequest
                        {
                            ChatId = chatId,
                            Text = "Sesión finalizada o paciente no encontrado. Por favor ingresa tu ID nuevamente."
                        });
                    }
                    break;
            }

            var callbackRequest = new AnswerCallbackQueryRequest
            {
                CallbackQueryId = query.Id
            };
            await _bot.SendRequest(callbackRequest);
        }

        private async Task MostrarMenuPrincipal(long chatId, Entity.Paciente paciente)
        {
            await _bot.SendRequest(new SendMessageRequest
            {
                ChatId = chatId,
                Text = $"¡Bienvenido, {paciente.Nombre} {paciente.Apellido}! ¿Qué deseas consultar?"
            });

            var menu = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("📄 Historial", $"historial|{paciente.NumeroDocumento}"),
                    InlineKeyboardButton.WithCallbackData("👨‍⚕️ Doctor", $"doctor|{paciente.NumeroDocumento}")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("📅 Próximas citas", $"citas|{paciente.NumeroDocumento}")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("🔄 Actualizar datos", $"actualizar|{paciente.NumeroDocumento}"),
                    InlineKeyboardButton.WithCallbackData("❓ Ayuda", $"ayuda|{paciente.NumeroDocumento}")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("⬅️ Volver al menú", $"volver|{paciente.NumeroDocumento}")
                }
            });

            await _bot.SendRequest(new SendMessageRequest
            {
                ChatId = chatId,
                Text = "Elige una opción:",
                ReplyMarkup = menu
            });
        }
    }
}
