using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace TS
{
	public class ChatModules : ModuleBase
	{
		[Command("ukihi")]
		public async Task Ball([Remainder, Summary("ukihi")] string message = null)
		{
			string[] responses = {  "What?",
										"No",
										"What could you possibly want from me?",
										"Go away",
										"http://66.media.tumblr.com/0fbbcbd6fcc28d36c70a83d538f41815/tumblr_mwnbvknt6A1qbvovho1_500.gif",
										"What do you want, trash?",
										"Leave me alone",
										"誰ですか？",
										"Die",
										"しね",
										"Could you leave me the hell alone?",
										"Stop saying my name",
										"Who let the retard out of their cage again?",
										"Oh, I didn't know you were capable of sentient speech",
										"I don't really feel like responding",
										"You're worse than my brother",
										"最低",
										"You're the worst",
										"Can you just die already?",
										"Ugh not now"};


			string response;

			response = responses[RandomNumber.Next(responses.Length)];
			await ReplyAsync(response);
		}
		[Command("ukihi I love you")]
		public async Task Love([Remainder, Summary("ukihi")] string message = null)
		{
			string[] responses = {  "lol",
										"Eww creepy",
										"Get the hell away from me",
										"Go away",
										"Sorry I don't marry animals",
										"Is this some kind of joke?",
										"Leave me alone",
										"誰ですか？",
										"Die",
										"しね",
										"Disgusting",
										"Pathetic",
										"How delusional do you have to be to fall in love with a bot?",
										"Oh, I didn't know you were capable of sentient speech",
										"https://i.imgur.com/pdfvvV8.png",
										"Yuck",
										"最低",
										"You're the worst",
										"Can you just die already?",
										"Ugh not now"};
			string response;

			response = responses[RandomNumber.Next(responses.Length)];
			await ReplyAsync(response);
		}
	}
}