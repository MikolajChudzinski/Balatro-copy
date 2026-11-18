using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balatro_copy
{

    class Cards
    {

        Value number;

        Suits suit;




        Cards(Value number, Suits suit)

        {

            this.number = number;

            this.suit = suit;

            this.suit = Suits.DIAMONDS;

        }


        public int PrintMe()

        {

            Console.WriteLine(this.suit.ToString() + this.number);

            return 1;

        }

    }

}

