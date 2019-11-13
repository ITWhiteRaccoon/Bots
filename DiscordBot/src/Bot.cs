using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace DiscordBot
{
    public class Bot
    {
        private DiscordSocketClient _client;

        public static void Main(string[] args)
        {
            new Bot().MainAsync().GetAwaiter().GetResult();
        }

        public async Task MainAsync()
        {
            string botToken = Environment.GetEnvironmentVariable("BotTokenDiscord", EnvironmentVariableTarget.User);
            string externalIp = FileOperations.GetCurrentServerIp();
            Console.WriteLine(externalIp);

            _client = new DiscordSocketClient();
            _client.Log += Log;
            await _client.LoginAsync(TokenType.Bot, botToken);
            await _client.StartAsync();
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}