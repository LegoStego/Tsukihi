using Discord;
using Discord.Commands;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Google.Apis.Customsearch.v1.Data;
using System.Xml.Linq;
using System.Net;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;

namespace TS
{
	public class Assortments : ModuleBase



	{

		private static ConcurrentDictionary<string, int> ratingList = new ConcurrentDictionary<string, int>();
		private readonly Random _random;

		public Assortments()
		{
			_random = new Random();
		}


		// ~say hello -> hello
		[Command("ay"), Summary("Echos a message.")]
		public async Task Say([Remainder, Summary("The text to echo")] string echo)
		{
			// ReplyAsync is a method on ModuleBase
			await ReplyAsync(echo);
			await Context.Message.DeleteAsync();
		}

		[Command("Reverse"), Summary("Reverses text")]
		public async Task Reverse([Remainder, Summary("Reverses text")] string Reverse)
		{
			// ReplyAsync is a method on ModuleBase
			await ReplyAsync(Reverse);
		}


		[Command("Rate"), Summary("Rates something for you out of 10.")]
		public async Task RateAsync([Remainder] string ThingToRate)
		{
			int rate = new Random().Next(11);
			if (ratingList.TryAdd(ThingToRate, rate))
			{
				// do nothing
			}
			else
				rate = ratingList[ThingToRate];
			await ReplyAsync($":thinking: I would rate '{ThingToRate}' a {rate}/10");
		}

		[Command("bmachine"), Summary("Rates something for you out of 10.")]
		public async Task BonerAsync([Remainder] string ThingToRate)
		   => await ReplyAsync($":thinking: I would rate that fap material a {new Random().Next(11)}/10");

		[Command("avatar")]
		public async Task BonerAsync([Remainder] IUser user = null)
		{


} 

		[Command("yeet")]
		[Summary("Y'all mind if I hit that?")]
		public async Task Yeet()
		{
			await Context.Channel.SendMessageAsync("http://i.imgur.com/mdJveVn.png");
		}
	
		[Command("Flip")]
		[Summary("Flip a coin. Heads or Tails.")]
		[Remarks("~flip")]
		public async Task FlipAsync()
		{
			int result;
			Random rnd = new Random();
			result = rnd.Next(2);
			if (result == 0)
				await ReplyAsync("Heads");
			else if (result == 1)
				await ReplyAsync("Tails");
		}

		[Command("pick"), Summary("Return random choice from space-separated list.")]
		[Alias("choice", "rngchoice", "c")]
		public async Task GetRandomChoiceAsync([Remainder] string message)
		{
			var components = message.Split("|");
			var selection = components[_random.Next(components.Length)];

			await ReplyAsync(selection);
		}
	
        [Command("time")]
		public async Task TimeAsync()
		{
			await ReplyAsync(DateTime.Now.ToShortTimeString());
		}
	}
}