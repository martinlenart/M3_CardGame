using System;

namespace M3_CardGame
{
    // Git
    // https://github.com/smarlen/M3_CardGame.git

    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard card1 = new PlayingCard { Color = PlayingCardColor.Diamonds, Value = PlayingCardValue.Ace };
            Console.WriteLine(card1);

            Console.WriteLine();
            PlayingCard card2 = new PlayingCard();
            Console.WriteLine(card2);

            DeckOfCards myDeck = new DeckOfCards();
            Console.WriteLine(myDeck[13]);
  
        }
    }
}
