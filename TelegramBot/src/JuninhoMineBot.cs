using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
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
            TelegramBotClient bot = new Telegram.Bot.TelegramBotClient(_botToken);
            return await bot.SendTextMessageAsync(destinationId, text);
        }
    }
}
