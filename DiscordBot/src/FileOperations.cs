using System.Net;

namespace DiscordBot
{
    public class FileOperations
    {
        private const string IpRetrievingWebsite = "http://ifconfig.me/ip";

        public static string GetCurrentServerIp()
        {
            string ipExterno = "";
            using (WebClient webClient = new WebClient())
            {
                ipExterno = webClient.DownloadString(IpRetrievingWebsite);
            }

            return ipExterno;
        }
    }
}