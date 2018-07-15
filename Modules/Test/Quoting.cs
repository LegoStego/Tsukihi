using Discord;
using Discord.Commands;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Google.Apis.Customsearch.v1.Data;
using System.Xml.Linq;
using System.Net;
using System.IO;

namespace B2
{
	public class Quoting : ModuleBase
	{

		private readonly Random _random;

		public Quoting()
		{
			_random = new Random();
		}

		[Command("quote")]
		public async Task Quote([Remainder, Summary("Quoting folks")]string person)
		{
			var comp = person.Split(" ")[0];
			var components = person.Split(" ")[1];
			var selection = components[(components.Length)];
			if (File.Exists(comp))
			{
				// Create a file to write to.
				using (StreamWriter sw = File.AppendText(comp))
				{
					sw.WriteLine(selection);
				}
			}
			else
			{
				using (StreamWriter sw = File.CreateText(comp))
				{
					sw.WriteLine(selection);
				}

			}
		}
	}
}