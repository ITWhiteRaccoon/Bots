using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;

namespace DiscordBot.src
{
    public class FileOperations
    {
        public static string RunBatch(string ipRetrievingWebsite)
        {

            return new WebClient().DownloadString(ipRetrievingWebsite);
        }

        public static void Main(string[] args)
        {
            Debug.WriteLine(RunBatch("http://ifconfig.me/ip"));
        }
    }
}
