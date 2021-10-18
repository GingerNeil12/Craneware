using CardGame.Domain.Enums;
using CardGame.Domain.Interfaces;

namespace CardGame.Domain
{
    public class Card : ICard
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public bool Equals(ICard other)
        {
            var result = true;

            if (Suit != other.Suit)
            {
                result = result && false;
            }

            if (Value != other.Value)
            {
                result = result && false;
            }

            return result;
        }
    }
}
