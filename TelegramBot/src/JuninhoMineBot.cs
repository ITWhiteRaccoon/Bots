using System.Net;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot
{
    public class JuninhoMineBot
    {
        private const string IpRetrievingWebsite = "http://ifconfig.me/ip";
        private readonly string _botToken;

        public JuninhoMineBot(string botToken)
        {
            _botToken = botToken;
        }

        public string GetCurrentServerIp()
        {
            string ipExterno = "";
            using (WebClient webClient = new WebClient())
            {
                ipExterno = webClient.DownloadString(IpRetrievingWebsite);
            }

            return ipExterno;
        }

        public async Task<Message> SendMessage(string destinationId, string text)
        {
            TelegramBotClient bot = new TelegramBotClient(_botToken);
            return await bot.SendTextMessageAsync(destinationId, text);
        }
    }
}