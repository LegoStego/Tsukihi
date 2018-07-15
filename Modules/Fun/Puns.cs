using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TS
{
	public class pun : ModuleBase
	{
		[Command("pun")]
		public async Task Pun()
		{
			string[] puns = {  "Yesterday I accidentally swallowed some food coloring. The doctor says I'm OK, but I feel like I've dyed a little inside.",
										"I wasn't originally going to get a brain transplant, but then I changed my mind.",
										"Did you hear about the guy whose whole left side was cut off? He's all right now.",
										"I'd tell you a chemistry joke but I know I wouldn't get a reaction.",
										"I wondered why the baseball was getting bigger. Then it hit me.",
										"Why don't some couples go to the gym? Because some relationships don't work out.",
										"A friend of mine tried to annoy me with bird puns, but I soon realized that toucan play at that game.",
										"Have you ever tried to eat a clock? It's very time consuming.",
										"Did you hear about the guy who got hit in the head with a can of soda? He was lucky it was a soft drink.",
										"I'm reading a book about anti-gravity. It's impossible to put down.",
										"When notes get in treble, bass-ically they get put behind bars. The alto-nate punishment is to push them off a clef and hope they land flat on sharp objects.",
										"A man just assaulted me with milk, cream and butter. How dairy.",
										"If there was someone selling drugs in this place, weed know.",
										"I used to be a banker but I lost interest",
										"My connection is unstable, ask again later",
										"I don't trust these stairs because they're always up to something.",
										"Why don't programmers like nature? It has too many bugs.",
										"A prisoner's favorite punctuation mark is the period. It marks the end of his sentence.",
										"He drove his expensive car into a tree and found out how the Mercedes bends.",
										"My dad died when we couldn't remember his blood type. As he died, he kept insisting for us to 'be positive,' but it's hard without him.",
										"Atheists don't solve exponential equations because they don't believe in higher powers.",
										"eBay is so useless. I tried to look up lighters and all they had was 13,749 matches.",
										"I just found out I'm colorblind. The diagnosis came completely out of the purple.",
										"Just burned 2,000 calories. That's the last time I leave brownies in the oven while I nap.",
										"Atheism is a non-prophet organization.",
			"Why do people think banks are boring? They're the definition of interesting."};




			string pun;

			pun = puns[RandomNumber.Next(puns.Length)];
			await ReplyAsync(pun);
		}
	}
}
