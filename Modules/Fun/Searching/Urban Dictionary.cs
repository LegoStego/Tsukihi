using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
	public class Urban : ModuleBase

	{
		[Command("ud", RunMode = RunMode.Async)]
		public async Task Dictionary([Remainder]string urbanstr)
		{
			using (System.Net.WebClient WebClient = new System.Net.WebClient())
			{
				string Resp = await WebClient.DownloadStringTaskAsync("http://api.urbandictionary.com/v0/define?term=" + urbanstr);
				Newtonsoft.Json.Linq.JToken JsonContent = Newtonsoft.Json.Linq.JToken.Parse(Resp);
				JsonContent = JsonContent.SelectToken("list.[0].definition");
				var embed = new EmbedBuilder()
						.WithTitle(urbanstr)
						.WithDescription(JsonContent.ToString())
						.WithColor(new Color(217, 13, 232));
				await ReplyAsync("", embed: embed.Build());
			}
		}
	}
}
