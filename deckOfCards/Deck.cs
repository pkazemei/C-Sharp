using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Deck
    {
        List<Card> cardsList = new List<Card> (); //a list of type class card

    public Deck ()
    {
        Reset(); //calling reset method to create a new deck
    }
    public Card Deal() //Deal method
    {
        Card tempCard = cardsList[0]; 

        cardsList.RemoveAt(0); //remove top card
        return tempCard;
    }

    public void Reset() //Reset method
    {
        cardsList.Clear();
        string[] stringVal = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
        string[] suit = {"Clubs", "Spades", "Hearts", "Diamonds"};
        int[] val = {1,2,3,4,5,6,7,8,9,10,11,12,13};

        foreach (var item1 in stringVal)
        {
            foreach (var item2 in suit)
            {
                foreach (var item3 in val)
                {
                    Card card = new Card (item1, item2, item3); //an instance of card class
                    cardsList.Add(card);
                }
            }
        }
    }

    public void Shuffle() //Shuffle method
    {
        var tempCard=cardsList[0];

        for (var i=0; i < cardsList.Count; i++)
        {
            var rand = new Random();
            int shuffle = rand.Next(cardsList.Count);

            var newTempCard=cardsList[i]; //stored as normal iteration of the for loop
            cardsList[i]=cardsList[shuffle]; //getting back random card values throughout the for loop
            cardsList[shuffle]=newTempCard;
        }
    }
    }
}