using System;
using System.Collections;
using System.Collections.Generic;
using CardGame.Domain.Interfaces;

namespace CardGame.Domain
{
    public class PackOfCardsEnumerator : IEnumerator<ICard>
    {
        private ICard[] _cards;
        private int _position = -1;

        public PackOfCardsEnumerator(ICard[] cards)
        {
            _cards = cards;
        }

        public ICard Current
        {
            get
            {
                try
                {
                    return _cards[_position];
                }
                catch (IndexOutOfRangeException exception)
                {
                    throw new InvalidOperationException("Unable to get Current Card.", exception);
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _cards.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        private void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                _cards = null;
            }
        }
    }
}
