using B2;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Linq;
using System.Threading.Tasks;

// Create a module with no prefix

// Create a module with the 'sample' prefix
public class Sample : ModuleBase
{
	// ~sample square 20 -> 400
	[Command("square"), Summary("Squares a number.")]
	public async Task Square([Summary("The number to square.")] int num)
	{
		// We can also access the channel from the Command Context.
		await Context.Channel.SendMessageAsync($"{num}^2 = {Math.Pow(num, 2)}");
	}

	// ~sample userinfo --> foxbot#0282
	// ~sample userinfo @Khionu --> Khionu#8708
	// ~sample userinfo Khionu#8708 --> Khionu#8708
	// ~sample userinfo Khionu --> Khionu#8708
	// ~sample userinfo 96642168176807936 --> Khionu#8708
	// ~sample whois 96642168176807936 --> Khionu#8708
	[Command("userinfo"), Summary("Returns info about the current user, or the user parameter, if one passed.")]
	[Alias("user", "whois")]
	public async Task UserInfo([Summary("The (optional) user to get info for")] IUser user = null)
	{
		var userInfo = user ?? Context.Client.CurrentUser;
		await ReplyAsync($"{userInfo.Username}#{userInfo.Discriminator}");
	}

	[Command("isinteger")]
	[Summary("Check if the input text is a whole number.")]
	public Task IsInteger(int number)
			=> ReplyAsync($"The text {number} is a number!");

	[Command("multiply")]
	[Summary("Get the product of two numbers.")]
	public async Task Say(int a, int b)
	{
		int product = a * b;
		await ReplyAsync($"The product of `{a} * {b}` is `{product}`.");
	}

	[Command("add")]
	[Summary("Get the sum of many numbers")]
	public async Task Say(params int[] numbers)
	{
		int sum = numbers.Sum();
		await ReplyAsync($"The sum of `{string.Join(", ", numbers)}` is `{sum}`.");
	}
}
