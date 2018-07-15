using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TS
{
	public class RandomService
	{
		private readonly Random _random = new Random();

		public async Task<int> RollDie(int sides)
		{
			return _random.Next(1, sides + 1);
		}

		public async Task<string> ChooseFromList(string list)
		{
			var choices = list.Split(';');
			return choices[_random.Next(0, choices.Length)];
		}
	}
}