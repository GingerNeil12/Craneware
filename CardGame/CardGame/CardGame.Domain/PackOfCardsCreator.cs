using System;
using System.Collections.Generic;
using CardGame.Domain.Enums;
using CardGame.Domain.Interfaces;

namespace CardGame.Domain
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            var cards = new List<ICard>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    cards.Add(new Card(suit, value));
                }
            }

            return new PackOfCards(cards.ToArray());
        }
    }
}
