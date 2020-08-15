
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Threading.Tasks;

namespace chaterbot.Commands
{ 
    class metacommands : BaseCommandModule
    {
        [Command("github")]
        [Aliases("aboutit", "about", "whatis", "yee", "ilovthisbot")]
        [Description("This shows the link and some info about the bot!")]
        public async Task Github(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();

            var embed = new DiscordEmbedBuilder
            {
                Title = "Thanks for your interest in our bot!",
                Description = "This bot is a meme/comedy bot, with a tiwst.",
                 ImageUrl = "https://media1.tenor.com/images/12d8aed0fe5f7ad9ae01ac3156888b98/tenor.gif?itemid=4904644",
                Color = DiscordColor.CornflowerBlue,
                Url= "https://github.com/Roflush/CharterBot",
                
            };

            embed.WithTimestamp(DateTime.Today);
            embed.WithFooter("by RoFlush/Para");


            await ctx.Channel.SendMessageAsync(embed: embed).ConfigureAwait(false);
        }
    }
}
