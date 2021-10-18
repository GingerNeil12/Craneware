using System;

namespace CardGame.Domain.Exceptions
{
    public class PackOfCardsEmptyException : Exception
    {
        public PackOfCardsEmptyException()
            : base("No cards left to take from the top.")
        {
        }
    }
}
