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
        private readonly string botUrl;
        private readonly TelegramBotClient bot;

        public JuninhoMineBot(string botToken)
        {
            bot = new TelegramBotClient(botToken);
            botUrl = "https://api.telegram.org/bot" + botToken;
        }

        public void SendCurrentIpToBot()
        {
            string ipExterno;
            string webReturnStr;
            using (WebClient webClient = new WebClient())
            {
                ipExterno = webClient.DownloadString(IpRetrievingWebsite) + ":25565";
                webReturnStr = webClient.DownloadString(botUrl + "/getUpdates");
            }

            var webReturn = JObject.Parse(webReturnStr);

            string chatId = webReturn.SelectToken("result[0].message.chat.id").ToString();
            string messageUrl = botUrl + "/sendMessage?chat_id={0}&text={1}";
            string.Format(messageUrl, chatId, ipExterno);
        }
    }
}
