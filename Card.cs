using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatro_copy
{
    public class BasicCard
    {
        public BasicCard(Value value, Suit suit)
        {
            Value = value;
            Suit = suit;
        }

        public Value Value { get; }
        public Suit Suit { get; }
    }
}

