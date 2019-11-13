using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TelegramBot
{
    public class Test
    {
        private const string GroupId = "-342712914";

        public static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        public static async Task MainAsync(string[] args)
        {
            Console.WriteLine("Sending message...");
            JuninhoMineBot juninho = new JuninhoMineBot(Environment.GetEnvironmentVariable("BotTokenTelegram", EnvironmentVariableTarget.User));
            string ip = juninho.GetCurrentServerIp();
            Message result = await juninho.SendMessage(GroupId, ip);
            Console.WriteLine("Message sent.");
            Console.WriteLine(result);
        }
    }
}