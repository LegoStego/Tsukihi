using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
	public class ping : ModuleBase
	{
		[Command("ping"), Summary("Replies with the time it takes to receive a message from Harmony")]
		public async Task Ping()
		{
			var sw = Stopwatch.StartNew();
			var msg = await Context.Channel.SendMessageAsync("pong");
			await msg.ModifyAsync(properties =>
			{
				properties.Content = string.Format(":ping_pong: pong! `{0}ms`", sw.ElapsedMilliseconds);
			});
		}
	}
}
