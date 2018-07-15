using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
	public class ball : ModuleBase

	{
		[Command("ball")]
		public async Task Ball([Remainder, Summary("8ball")] string Random)
		{
			string[] responses = {  "I'm gonna say yes",
										"I'm gonna say no",
										"Without a doubt",
										"Yes, definitely",
										"You bet",
										"As I see it, yes",
										"Yeah yeah, outlook is good",
										"Outlook good",
										"Yes",
										"Signs point to yes",
										"Lazy, don't wanna respond",
										"Ask again later",
										"Why should I answer?",
										"How should I know? Ask me later",
										"I don't really feel like answering",
										"Don't count on it",
										"My reply is no",
										"My sources say no",
										"Outlook not so good",
										"Go away"};



			string response;

			response = responses[RandomNumber.Next(responses.Length)];
			await ReplyAsync(response);
		}
	}
}
