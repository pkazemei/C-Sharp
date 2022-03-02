using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Player
    {
        string name;
        List<Card> handsList = new List<Card> ();

        public Card Draw(Deck dk)
        {
            var temp= dk.Deal();
            handsList.Add(temp); //take top card from deck and add to your hand
            return temp;
        }

        public Card Discard(int idx)
        {
            if(idx>handsList.Count)
            {
                return null;
            }
            else
            {
                var temp = handsList[idx];
                handsList.RemoveAt(idx);
                return temp;
            }
        }
    }
}