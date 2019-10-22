using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TelegramBot
{
    public class Test
    {
        private const string BotToken = "891088321:AAHIbV4R6KJrkteu-_GupytVPnYDEK9OuCk";

        public static void Main(string[] args)
        {
            JuninhoMineBot juninho = new JuninhoMineBot(BotToken);
            Task<Message> mensagemRetorno = juninho.SendCurrentIpToBot();
        }
    }
}
