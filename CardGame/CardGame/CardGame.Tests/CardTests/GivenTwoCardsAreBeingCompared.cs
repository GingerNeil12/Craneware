using CardGame.Domain;
using CardGame.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGame.Tests.CardTests
{
    [TestClass]
    public class GivenTwoCardsAreBeingCompared
    {
        [TestMethod]
        public void WhenBothSuitAndValuesAreEqual_ThenEqualsShouldReturnTrue()
        {
            // Arrange
            var cardOne = new Card(Suit.Clubs, Value.Ace);
            var cardTwo = new Card(Suit.Clubs, Value.Ace);

            // Act
            var result = cardOne.Equals(cardTwo);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WhenTheSuitIsDifferentButValueIsEqual_ThenEqualsReturnsFalse()
        {
            // Arrange
            var cardOne = new Card(Suit.Clubs, Value.Ace);
            var cardTwo = new Card(Suit.Diamonds, Value.Ace);

            // Act
            var result = cardOne.Equals(cardTwo);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WhenTheSuitIsEqualButTheValueIsDifferent_ThenEqualsReturnsFalse()
        {
            // Arrange
            var cardOne = new Card(Suit.Clubs, Value.Ace);
            var cardTwo = new Card(Suit.Clubs, Value.Eight);

            // Act
            var result = cardOne.Equals(cardTwo);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WhenBothTheSuitAndValuesAreDifferent_ThenEqualsShouldReturnFalse()
        {

            // Arrange
            var cardOne = new Card(Suit.Clubs, Value.Ace);
            var cardTwo = new Card(Suit.Diamonds, Value.Eight);

            // Act
            var result = cardOne.Equals(cardTwo);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
