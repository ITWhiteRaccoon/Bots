using Discord;
using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class Bot
    {
        private const String token = "";

        public static void Main(string[] args)
            => new Bot().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {

        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
