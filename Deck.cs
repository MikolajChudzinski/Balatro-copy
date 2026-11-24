
using System;
using System.Collections.Generic;

namespace balatro_copy
{
    public class Deck
    {
        private readonly List<BasicCard> cards = new();
        private readonly List<BasicCard> drawnCards = new();

       
        public Deck()
        {
            cards = new List<BasicCard>();
            drawnCards = new List<BasicCard>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    cards.Add(new BasicCard(value, suit));
                }
            }
        }

        public BasicCard DrawCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("There are no cards left in the deck.");
            }

            BasicCard card = cards[0];

            cards.Remove(card);
            drawnCards.Add(card);

            return card;
        }

        public int GetAvailableCardsCount()
        {
            return cards.Count;
        }

        public int GetDrawnCardsCount()
        {
            return drawnCards.Count;
        }
    }
}


