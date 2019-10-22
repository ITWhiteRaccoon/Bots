using System;
using System.Threading.Tasks;
using Discord;

namespace DiscordBot.src
{
    public class Bot
    {
        private const String Token = "";

        public static void Main(string[] args)
            => new Bot().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            string externalIp = FileOperations.GetIp("IpCheck.bat");
            Console.WriteLine(externalIp);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
