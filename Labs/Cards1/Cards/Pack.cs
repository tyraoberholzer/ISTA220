using System;

namespace Cards
{	
	class Pack
	{
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        private PlayingCard[,] cardPack;
        private Random randomCardSelector = new Random();

        public Pack()
        {
            cardPack = new PlayingCard[NumSuits, CardsPerSuit];
            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
                for (Value value = Value.Two; value <= Value.Ace; value++)
                    cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
        }
        
        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);
            //if suit is empty pick another suit (meaning of line 25 & 26)
            while (IsSuitEmpty(suit))
                suit = (Suit)randomCardSelector.Next(NumSuits);

            Value value = (Value)randomCardSelector.Next(CardsPerSuit);
            //if card already dealt pick another card
            while (IsCardAlreadyDealt(suit, value))
                value = (Value)randomCardSelector.Next(CardsPerSuit);

            PlayingCard card = this.cardPack[(int)suit, (int)value];
            //when we deal a card, set the place to null
            cardPack[(int)suit, (int)value] = null;
            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;
            for (Value value = Value.Two; value <= Value.Ace; value ++)
            {
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            return cardPack[(int)suit, (int)value] == null;
        }
    }
}





//public const int NumSuits = 4; symbolic constant-a name that we give to a number; giving #4 the name NumSuits
//public const int CardsPerSuit = 13; it is a symbolic constant;  giving #13 the name CardsPerSuit
//private PlayingCard[,] cardPack; PlayingCard is a class; [,] a multidimensional array; cardPack is the name of the array
//private Random randomCardSelector = new Random(); creates an object of type Random that we name randomCardSelector
//public Pack() is a constructor because it has the same name as the class and it does not have a return type
//cardPack = new PlayingCard[NumSuits, CardsPerSuit]; CardsPerSuit is a symbolic constant standing for 13; NumSuits is a symbolic constant standing for 4; PlayingCard is a type of array; cardPack is the name of the array
//for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++); for creates a loop; Suit is an enum; suit is the name of the Suit enum; = is the assignment operator; Suit.Clubs is the value of 0; Suit.Spades is 3; 
//cardPack[(int)suit, (int)value] = new PlayingCard(suit, value); new PlayingCard(suit, value) -- new allocates memory in the heap for the new 