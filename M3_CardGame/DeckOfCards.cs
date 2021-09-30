using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_CardGame
{
    class DeckOfCards
    {
        PlayingCard[] cards = new PlayingCard[52];

        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }

        public DeckOfCards()
        {
            int cardNr = 0;
            for (PlayingCardColor c = PlayingCardColor.Clubs; c <= PlayingCardColor.Spades; c++)
            {
                for (PlayingCardValue v = PlayingCardValue.Two; v <= PlayingCardValue.Ace; v++)
                {
                    cards[cardNr] = new PlayingCard { Color = c, Value = v };
                    cardNr++;
                }
            }
        }
    }
}
