namespace Cards
{
	class PlayingCard
	{
        private readonly Suit suit;
        private readonly Value value;

		public PlayingCard(Suit s, Value v)
		{
			suit = s;
			value = v;
		}

        public override string ToString()
		{
            string result = $"{value} of {suit}";
            return result;
		}

        public Suit CardSuit()
        {
            return suit;
        }

        public Value CardValue()
        {
            return value;
        }
	}
}

//Suit with an uppercase is an enum/type and suit with a lower is a variable name
//Value with an uppercase is an enum/type and value with a lower is a varaible name
//public PlayingCard(Suit s, Value v), is a constructor because it doesn't have a return value
//purpose of ToString it returns the string of the current object
//public Suit CardSuit(), Suit is the method, CardSuit is the name of the method ,and it returns the suit
//public Value CardValue(), Value is the method, CardValue is the name of the method, and it returns the suit