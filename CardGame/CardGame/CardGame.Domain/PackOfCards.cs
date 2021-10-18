using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CardGame.Domain.Exceptions;
using CardGame.Domain.Helpers;
using CardGame.Domain.Interfaces;

namespace CardGame.Domain
{
    public class PackOfCards : IPackOfCards
    {
        private ICard[] _cards = new ICard[52];
        private int _position = 0;

        public PackOfCards(ICard[] cards)
        {
            if (cards.Length != 52)
            {
                throw new IncorrectCardCountException(cards.Length);
            }

            Array.Copy(cards, _cards, cards.Length);
        }

        public int Count
        {
            get
            {
                return _cards.Length - _position;
            }
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return new PackOfCardsEnumerator(_cards);
        }

        public void Shuffle()
        {
            _cards = CardsInitializer.InitializeCards();
            _position = 0;
            var rng = new Random();
            _cards = _cards.OrderBy(card => rng.Next()).ToArray();
        }

        public ICard TakeCardFromTopOfPack()
        {
            if (_position > 51)
            {
                throw new PackOfCardsEmptyException();
            }
            var result = _cards[_position];
            _position++;
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
