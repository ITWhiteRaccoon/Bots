using System.Threading.Tasks;
using Discord.Commands;

namespace DiscordBot.Modules
{
    public class InfoModule : ModuleBase<SocketCommandContext>
    {
        [Command("say")]
        [Summary("Ëchoes a message.")]
        public Task SayAsync([Remainder] [Summary("The text to echo")]
            string echo)
            => ReplyAsync(echo);

        [Command("ip")]
        [Summary("Current server external IP Address.")]
        public async Task IpAddress()
            => await ReplyAsync(FileOperations.GetCurrentServerIp());
    }
}
