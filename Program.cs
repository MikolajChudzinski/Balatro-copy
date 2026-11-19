using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatro_copy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BasicCard card = new BasicCard(Value.Ace, Suit.Spades);

            System.Console.WriteLine(card.Value);
            System.Console.WriteLine(card.Suit);
        }
    }
}

