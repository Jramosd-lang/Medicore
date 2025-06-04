using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using TelegramBot.Services;

namespace TelegramBot
{
    class Program
    {
        static void Main()
        {
            var botToken = "8124475320:AAGxJwRj52SOVTdo9WrrxkdhW1-JakeQgJk"; // Reemplaza aquí
            var botClient = new TelegramBotClient(botToken);

            // Cancelación global
            using var cts = new CancellationTokenSource();

            // Controlador central
            var controller = new BotController(
            botClient,
            new TelegramPacienteService(),
            new TelegramCitaService()
            );


            // Recibe TODO tipo de actualizaciones
            var receiverOptions = new ReceiverOptions
            { AllowedUpdates = Array.Empty<UpdateType>() };

            botClient.StartReceiving(
                controller.HandleUpdateAsync,
                controller.HandleErrorAsync,
                receiverOptions,
                cts.Token
            );

            Console.WriteLine("Bot en línea. Presiona ENTER para salir.");
            Console.ReadLine();
            cts.Cancel();
        }
    }
}
