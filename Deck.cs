using System;
using System.Collections.Generic;

namespace balatro_copy
{
    public class Deck
    {
        private List<BasicCard> cards;

        public Deck()
        {
            cards = new List<BasicCard>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {

                }
            }
        }
    }
}