using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace chaterbot.Commands
{
    class nemaCommmands : BaseCommandModule
    {

        [Command("neme")]
        [Aliases("nemamemes", "nema", "kaylon", "kaylonmemes")]
        [Description("Shows memes made about the alliance Nema after it fell apart.")]
        public async Task Quotes(CommandContext ctx)
        {
            await ctx.TriggerTypingAsync();
            var random = new Random();
            var list = new List<string> { "https://i.imgflip.com/3kwct4.jpg", "https://i.imgflip.com/3kwdfh.jpg", "https://i.imgflip.com/3kwckg.jpg", "https://i.imgflip.com/3kwbi1.jpg", "https://i.imgflip.com/3kwc2p.jpg", "https://i.imgflip.com/3kwal0.jpg", "https://i.imgflip.com/3kw9kf.jpg", "https://i.imgflip.com/3kw85y.jpg", "https://i.imgflip.com/3kwlpj.jpg", "https://i.imgflip.com/3kwlg4.jpg", "https://i.imgflip.com/3kwkvx.jpg", "https://i.imgflip.com/3kwk88.jpg", "https://i.imgflip.com/3kwjwk.jpg", "https://i.imgflip.com/3kwjmz.jpg", "https://i.imgflip.com/3kwj23.jpg", "https://i.imgflip.com/3kwimd.jpg", "https://i.imgflip.com/3kwins.jpg", "https://i.imgflip.com/3kwi83.jpg", "https://i.imgflip.com/3kwgrq.jpg", "https://i.imgflip.com/3kwgh3.jpg", "https://i.imgflip.com/3kwfjf.jpg", "https://i.imgflip.com/3kwegm.jpg", "https://i.imgflip.com/3kwdxr.jpg", "https://i.imgflip.com/3kwdfh.jpg", "https://i.imgflip.com/3kx2ly.jpg", "https://i.imgflip.com/3kwnph.jpg", "https://i.imgflip.com/3kwnky.jpg", "https://i.imgflip.com/3kwmrw.jpg", "https://i.imgflip.com/3kwm8i.jpg", "https://i.imgflip.com/3kwm4u.jpg", "https://i.imgflip.com/3kwlyl.jpg", };
            int index = random.Next(list.Count);

            var embed = new DiscordEmbedBuilder
            {
                Title = "Nema gettting memed",
                Description = "Awaiting the lawsuit",
                ImageUrl = list[index],
                Color = DiscordColor.Turquoise,
            };

            embed.WithFooter("MADE BY para//Roflush.");

            await ctx.Channel.SendMessageAsync(embed: embed).ConfigureAwait(false);
        }

        [Command("nmastory")]
        [Description("This gives the story on what happened.")]
        public async Task nemastory(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Test").ConfigureAwait(false);
        }
    }
}
