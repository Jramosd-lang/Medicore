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
        private readonly ICitaService _citaSvc;

        public BotController(
            ITelegramBotClient bot,
            IPacienteService pacienteSvc,
            ICitaService citaSvc)
        {
            _bot = bot;
            _pacienteSvc = pacienteSvc;
            _citaSvc = citaSvc;
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

            var paciente = await _pacienteSvc.GetByDocumentoAsync(text);
            if (paciente == null)
            {
                await _bot.SendRequest(new SendMessageRequest
                {
                    ChatId = chatId,
                    Text = "Bienvenido a MediCore. Por favor, ingresa tu número de documento para consultar tus citas."
                });
                return;
            }
            else
            {
                await MostrarMenuPrincipal(chatId, paciente);
            }
        }

        private async Task HandleCallbackAsync(Telegram.Bot.Types.CallbackQuery query)
        {
            var chatId = query.Message.Chat.Id;
            var parts = query.Data.Split('|');
            var action = parts[0];
            var documento = parts.Length > 1 ? parts[1] : "";

            switch (action)
            {
                case "proximas":
                    var citasProximas = (await _citaSvc.GetCitasPorPacienteAsync(documento))
                        .Where(c => c.Fecha >= DateTime.Today)
                        .OrderBy(c => c.Fecha)
                        .ToList();
                    if (citasProximas.Count == 0)
                    {
                        await _bot.SendRequest(new SendMessageRequest
                        {
                            ChatId = chatId,
                            Text = "No tienes citas próximas."
                        });
                    }
                    else
                    {
                        string msg = "🗓 *Tus próximas citas:*\n\n";
                        foreach (var cita in citasProximas)
                        {
                            msg += $"• {cita.Fecha:dd/MM/yyyy} - {cita.Hora} hs\n  Doctor: {cita.NombreDoctor}\n  Motivo: {cita.Motivo}\n  Estado: {cita.Estado ?? "No especificado"}\n\n";
                        }
                        await _bot.SendRequest(new SendMessageRequest
                        {
                            ChatId = chatId,
                            Text = msg,
                            ParseMode = Telegram.Bot.Types.Enums.ParseMode.Markdown
                        });
                    }
                    break;

                case "pasadas":
                    var citasPasadas = (await _citaSvc.GetCitasPorPacienteAsync(documento))
                        .Where(c => c.Fecha < DateTime.Today)
                        .OrderByDescending(c => c.Fecha)
                        .ToList();
                    if (citasPasadas.Count == 0)
                    {
                        await _bot.SendRequest(new SendMessageRequest
                        {
                            ChatId = chatId,
                            Text = "No tienes citas anteriores."
                        });
                    }
                    else
                    {
                        string msg = "🗓 *Tus citas pasadas:*\n\n";
                        foreach (var cita in citasPasadas)
                        {
                            msg += $"• {cita.Fecha:dd/MM/yyyy} - {cita.Hora} hs\n  Doctor: {cita.NombreDoctor}\n  Motivo: {cita.Motivo}\n  Estado: {cita.Estado ?? "No especificado"}\n\n";
                        }
                        await _bot.SendRequest(new SendMessageRequest
                        {
                            ChatId = chatId,
                            Text = msg,
                            ParseMode = Telegram.Bot.Types.Enums.ParseMode.Markdown
                        });
                    }
                    break;

                case "datos":
                    var pacienteDatos = await _pacienteSvc.GetByDocumentoAsync(documento);
                    if (pacienteDatos == null)
                    {
                        await _bot.SendRequest(new SendMessageRequest
                        {
                            ChatId = chatId,
                            Text = "No se encontraron tus datos."
                        });
                    }
                    else
                    {
                        string datosMsg = $"📝 *Tus datos:*\n" +
                            $"Nombre: {pacienteDatos.Nombre} {pacienteDatos.Apellido}\n" +
                            $"Correo: {pacienteDatos.Correo}\n" +
                            $"Teléfono: {pacienteDatos.Telefono}\n" +
                            $"Ocupación: {pacienteDatos.Ocupacion}\n" +
                            $"Sexo: {pacienteDatos.Sexo}\n" +
                            $"Religión: {pacienteDatos.Religion}";
                        await _bot.SendRequest(new SendMessageRequest
                        {
                            ChatId = chatId,
                            Text = datosMsg,
                            ParseMode = Telegram.Bot.Types.Enums.ParseMode.Markdown
                        });
                    }
                    break;

                case "volver":
                    var pacienteV = await _pacienteSvc.GetByDocumentoAsync(documento);
                    if (pacienteV != null)
                        await MostrarMenuPrincipal(chatId, pacienteV);
                    break;

                case "ayuda":
                    await _bot.SendRequest(new SendMessageRequest
                    {
                        ChatId = chatId,
                        Text = "¿Necesitas ayuda? Comunícate con nosotros a:\n📞 3106933004\n✉️ recepcion@medicore.com\n¡Estamos para ayudarte!"
                    });
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
            var menu = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("📅 Próximas citas", $"proximas|{paciente.NumeroDocumento}"),
                    InlineKeyboardButton.WithCallbackData("📖 Citas pasadas", $"pasadas|{paciente.NumeroDocumento}")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("👤 Mis datos", $"datos|{paciente.NumeroDocumento}")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("🔄 Volver al menú", $"volver|{paciente.NumeroDocumento}"),
                    InlineKeyboardButton.WithCallbackData("❓ Ayuda", $"ayuda|{paciente.NumeroDocumento}")
                }
            });

            await _bot.SendRequest(new SendMessageRequest
            {
                ChatId = chatId,
                Text = $"¡Hola, {paciente.Nombre} {paciente.Apellido}! ¿Qué deseas consultar?",
                ReplyMarkup = menu
            });
        }
    }
}
