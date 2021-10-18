using CardGame.Domain;
using CardGame.Domain.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGame.Tests.PackOfCardsTests
{
    [TestClass]
    public class GivenAPackOfCardsNeedsShuffling : PackOfCardsBaseTest
    {
        private IPackOfCards _packOfCardsUnderTest;

        [TestInitialize]
        public void TestInitialize()
        {
            _packOfCardsUnderTest = new PackOfCards(GetCards());
        }

        [TestMethod]
        public void WhenShuffleIsCalled_ThenTheCardsShouldBeResetToFullAndShouldBeInARandomOrder()
        {
            // Arrange
            var topCardOfSetupDeck = GetCards()[0];

            // Act
            _packOfCardsUnderTest.Shuffle();
            var topCardOfShuffledDeck = _packOfCardsUnderTest.TakeCardFromTopOfPack();

            // Assert
            Assert.AreEqual(51, _packOfCardsUnderTest.Count);
            Assert.IsFalse(topCardOfShuffledDeck.Equals(topCardOfSetupDeck));
        }

        [TestMethod]
        public void WhenACardHasBeenTakenFromThePackAndShuffleIsCalled_ThenTheCardsShouldBeResetToFullAndShouldBeInARandomOrder()
        {
            // Arrange
            _ = _packOfCardsUnderTest.TakeCardFromTopOfPack();

            // Act
            var countBeforePackIsShuffled = _packOfCardsUnderTest.Count;
            _packOfCardsUnderTest.Shuffle();

            // Assert
            Assert.AreEqual(51, countBeforePackIsShuffled);
            Assert.AreEqual(52, _packOfCardsUnderTest.Count);
        }
    }
}
