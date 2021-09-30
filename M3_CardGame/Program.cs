using System;

namespace M3_CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCard card1 = new PlayingCard { Color = PlayingCardColor.Diamonds, Value = PlayingCardValue.Ace };
            Console.WriteLine(card1);

            Console.WriteLine();
            PlayingCard card2 = new PlayingCard();
            Console.WriteLine(card2);
        }
    }
}
