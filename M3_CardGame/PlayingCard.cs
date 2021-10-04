using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_CardGame
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	public class PlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		#region ToString() related
		public bool Verbose { get; set; } = true;

		//Use switch statment or switch expression
		//https://en.wikipedia.org/wiki/Playing_cards_in_Unicode
		public string ShortDescription
		{
			get
			{
				char c = Color switch
				{
					PlayingCardColor.Clubs => '\x2663',
					PlayingCardColor.Diamonds => '\x2666',
					PlayingCardColor.Hearts => '\x2665',
					_ => '\x2660', // Spades
				};
				return $"{c} {Value.ToString()}";
			}
		}
		public string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		public override string ToString()
		{
			if (!Verbose)
				return $"{ShortDescription}";
			else
				return $"{ShortDescription}: {Value} of {Color}, a {BlackOrRed} card";
		}
        #endregion

        public PlayingCard() 
		{
			Color = PlayingCardColor.Clubs;
			Value = PlayingCardValue.Ace;
		}
	}
}
