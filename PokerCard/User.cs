using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerCard
{
    public class User
    {
        private List<PaperCard> listCard = new List<PaperCard>();

        public string Name { get; set; }

        public User(string strName)
        {
            this.Name = strName; 
        }
        public void Add(PaperCard p)
        {
            listCard.Add(p);
        }

        public void Reset()
        {
            listCard.Clear();
        }

        public void Introduce()
        {
            string strCards = "";

            for (int i = 0; i < listCard.Count; i++)
            {
                if (i == 0)
                {
                    strCards += listCard[i].Name;
                }
                else
                {
                    strCards += ", " + listCard[i].Name;
                }
            }
            Console.WriteLine("\r\n--------------------------------------------");
            Console.Write("我是玩家{0}，", Name);
            Console.Write("我手中的撲克牌有{0}張:\r\n{1}\r\n", listCard.Count, strCards);
        }
    }
}
