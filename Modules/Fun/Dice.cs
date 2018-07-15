using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
	public class Dice : ModuleBase
	{
		[Command("Roll")]
		[Summary("Rolls a die with the specified number of sides. If no number is given then the die rolls with 6 sides as the default.")]
		[Remarks("~Roll <sides of the die>")]
		public async Task RollDice(int sides = 6)
		{
			if (sides < 2)
			{
				await ReplyAsync("Die must have 2 or more sides."); // Prevents users from rolling 1 or 0 sided die or negative sides.
			}
			else
			{
				int result;
				Random rnd = new Random();
				result = rnd.Next(1, sides + 1); // The maxValue of Random() is exclusive, so it will never return the max value.
				if (result == sides)
				{
					var critEmbed = new EmbedBuilder()
						.WithTitle("Dice Roll")
						.WithDescription($"{Context.User.Mention} rolled a {sides} sided die and got **{result}!** Nice!")
						.WithColor(new Color(217, 13, 232));
					await ReplyAsync("", embed: critEmbed.Build());
				}
				else if (result == 1) // Lower limit
				{
					var failEmbed = new EmbedBuilder()
						.WithTitle("Dice Roll")
						.WithDescription($"{Context.User.Mention} rolled a {sides} sided die and got **{result}!** Sucks to be you.")
						.WithColor(new Color(217, 13, 232));
					await ReplyAsync("", embed: failEmbed.Build());
				}
				else
				{
					var embed = new EmbedBuilder()
						.WithTitle("Dice Roll")
						.WithDescription($"{Context.User.Mention} rolled a {sides} sided die and got **{result}**.")
						.WithColor(new Color(217, 13, 232));
					await ReplyAsync("", embed: embed.Build());
				}
			}
		}
	}
}
