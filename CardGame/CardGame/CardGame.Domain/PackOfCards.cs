using System;
using System.Collections;
using System.Collections.Generic;
using CardGame.Domain.Exceptions;
using CardGame.Domain.Interfaces;

namespace CardGame.Domain
{
    public class PackOfCards : IPackOfCards
    {
        private ICard[] _cards = new ICard[52];

        public PackOfCards(ICard[] cards)
        {
            if (cards.Length != 52)
            {
                throw new IncorrectCardCountException(cards.Length);
            }

            Array.Copy(cards, _cards, cards.Length);
        }

        public int Count => _cards.Length;

        public IEnumerator<ICard> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public ICard TakeCardFromTopOfPack()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
