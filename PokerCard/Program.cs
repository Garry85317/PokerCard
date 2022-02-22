using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerCard
{
	internal class Program
	{
		public static void Main()
		{
			Console.Write("請輸入玩家人數：");
			int n = int.Parse(Console.ReadLine());
			if (n == 0)
			{
				Console.WriteLine("沒人想打牌");
				Console.ReadKey();
				return;
			}
			else if (n > 52)
			{
				Console.WriteLine("有人會沒有牌 \n");
			}

			//產生撲克牌
			Console.WriteLine("正在生成撲克牌... \n");
			List<PaperCard> myCards = new List<PaperCard>();

			for (int i = 0; i < 52; i++)
			{
				PaperCard p = new PaperCard(i);
				myCards.Add(p);
			}

			//洗牌
			Console.WriteLine("正在洗牌... \n");
			Stack<PaperCard> stackCard = new Stack<PaperCard>();
			Random r = new Random();

			while (myCards.Count > 0)
			{
				int iIndex = r.Next(0, myCards.Count);
				stackCard.Push(myCards[iIndex]);
				myCards.RemoveAt(iIndex);
			}

			//發牌 
			Console.WriteLine("開始發牌... \n");
			List<User> listUser = new List<User>();

			for (int i = 1; i <= n; i++)
			{
				User user = new User(i.ToString());
				listUser.Add(user);
			}

			while (stackCard.Count > 0)
			{
				for (int s = 0; s < listUser.Count; s++)
				{
					listUser[s].Add(stackCard.Pop());
					if (stackCard.Count < 1)
						break;
				}
			}

			Console.WriteLine("發牌完成！\n");

			//看牌
			foreach (var item in listUser)
			{
				item.Introduce();
			}
			Console.ReadKey();
		}
	}
}
