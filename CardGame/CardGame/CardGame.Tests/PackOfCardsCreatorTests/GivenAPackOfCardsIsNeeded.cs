using System.Linq;
using CardGame.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGame.Tests.PackOfCardsCreatorTests
{
    [TestClass]
    public class GivenAPackOfCardsIsNeeded
    {
        [TestMethod]
        public void WhenCreateIsCalled_ThenItShouldCreateAPackOfCardsWith52UniqueCardsInIt()
        {
            // Arrange
            var packOfCardsCreatorUnderTest = new PackOfCardsCreator();

            // Act
            var packOfCards = packOfCardsCreatorUnderTest.Create();
            var packOfCardsDistinct = packOfCards.Distinct().ToList();

            // Assert
            Assert.IsNotNull(packOfCards);
            Assert.AreEqual(52, packOfCards.Count);
            Assert.AreEqual(52, packOfCardsDistinct.Count);
        }
    }
}
