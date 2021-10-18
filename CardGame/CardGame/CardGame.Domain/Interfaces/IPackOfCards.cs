using System.Collections.Generic;

namespace CardGame.Domain.Interfaces
{
    public interface IPackOfCards : IReadOnlyCollection<ICard>
    {
        void Shuffle();
        ICard TakeCardFromTopOfPack();
    }
}
