using System;
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
        private string botUrl;
        private TelegramBotClient bot;

        public JuninhoMineBot(string botToken)
        {
            bot = new TelegramBotClient(botToken);
            botUrl = "https://api.telegram.org/bot" + botToken + "/getUpdates";
        }

        public async Task<Message> SendCurrentIpToBot()
        {
            string ipExterno;
            string webReturnStr;
            using (WebClient webClient = new WebClient())
            {
                ipExterno = webClient.DownloadString(IpRetrievingWebsite);
                webReturnStr = webClient.DownloadString(botUrl);
            }

            var webReturn = JObject.Parse(webReturnStr);
            if (webReturn.Count <= 1 || !webReturn["ok"].Value<bool>())
            {
                return null;
            }

            string chatId = webReturn.SelectToken("result[0].message.chat.id").ToString();

            Message mensagemRetorno = await bot.SendTextMessageAsync(chatId, ipExterno);
            return mensagemRetorno;
        }
    }
}
