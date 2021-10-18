using System;

namespace CardGame.Domain.Exceptions
{
    public class IncorrectCardCountException : Exception
    {
        public int CardCount { get; }

        public IncorrectCardCountException(int cardCount)
            : base($"Pack of Cards should contain 52 cards. Card Count supplied: {cardCount}")
        {
            CardCount = cardCount;
        }
    }
}
