using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerCard
{
    public class PaperCard
    {
        public int Number { get; set; }
        public PaperCard(int Num)
        {
            this.Number = Num;
        }

        public string Name
        {
            get
            {
                return string.Format("{0}", this.Number);
            }

            private set { }
        }
    }
}
