using System.Diagnostics;
using System.Net;

namespace DiscordBot
{
    public class FileOperations
    {
        public static string GetIp(string ipRetrievingWebsite)
        {
            return new WebClient().DownloadString(ipRetrievingWebsite);
        }

        //public static void Main(string[] args)
        //{
        //    Debug.WriteLine(GetIp("http://ifconfig.me/ip"));
        //}
    }
}
