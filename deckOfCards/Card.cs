using System;

namespace deckOfCards
{
    class Card
    {
        string stringVal;
        string suit;
        int val;

        public Card (string sVal, string st, int vl) //constructor
        {
            stringVal=sVal;
            suit=st;
            val=vl;

        }
    }
}