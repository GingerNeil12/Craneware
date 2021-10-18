using CardGame.Domain.Helpers;
using CardGame.Domain.Interfaces;

namespace CardGame.Domain
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            return new PackOfCards(CardsInitializer.InitializeCards());
        }
    }
}
