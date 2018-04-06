using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps
{
    class Card
    {
        public string suit;
        public int value;

        public Card(string v, string c)
        {
            convert(v);
            suit = c;
        }

        //Convert the 2, 3, 4, 5, 6, 7, 8, 9, T, J, Q, K, A to numbers;

        public void convert(string x)
        {
            switch (x)
            {
                case "A":
                    value = 14;
                    return;
                case "K":
                    value = 13;
                    return;

                case "Q":
                    value = 12;
                    return;

                case "J":
                    value = 11;
                    return;

                case "T":
                    value = 10;
                    return;

                default:
                    value = int.Parse(x);
                    return;
            }
        }
    }
}
