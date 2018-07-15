using System;
using System.Collections.Generic;
using System.Text;

namespace TS
{
	class RandomNumber
	{
		private static readonly Random random = new Random();
		private static readonly object syncLock = new object();

		public static int Next(int min, int max)
		{
			lock (syncLock)
			{
				return random.Next(min, max);
			}
		}

		public static int Next(int max)
		{
			lock (syncLock)
			{
				return random.Next(max);
			}
		}
	}
}