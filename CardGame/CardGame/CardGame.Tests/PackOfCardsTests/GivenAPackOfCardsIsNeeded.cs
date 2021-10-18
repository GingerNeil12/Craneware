using System;
using System.Linq;
using CardGame.Domain;
using CardGame.Domain.Enums;
using CardGame.Domain.Exceptions;
using CardGame.Domain.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGame.Tests.PackOfCardsTests
{
    [TestClass]
    public class GivenAPackOfCardsIsNeeded : PackOfCardsBaseTest
    {
        [TestMethod]
        public void WhenConstructedWithCorrectCardCount_ThenCountShouldReturn52()
        {
            // Arrange
            // Act
            var packOfCards = new PackOfCards(GetCards());

            // Assert
            Assert.AreEqual(52, packOfCards.Count);
        }

        [TestMethod]
        public void WhenConstructedWithLessThan52Cards_ThenThrowsIncorrectCardCountException()
        {
            // Arrange
            var cards = new ICard[] { new Card(Suit.Clubs, Value.Ace) };

            // Act
            Action action = () => new PackOfCards(cards);

            // Assert
            var exception = Assert.ThrowsException<IncorrectCardCountException>(action);
            Assert.AreEqual(cards.Length, exception.CardCount);
            Assert.AreEqual($"Pack of Cards should contain 52 cards. Card Count supplied: {cards.Length}", exception.Message);
        }

        [TestMethod]
        public void WhenConstructedWithMoreThan52Cards_ThenThrowsIncorrectCardCountException()
        {
            // Arrange
            var cards = GetCards().Concat(new ICard[] { new Card(Suit.Clubs, Value.Ace) }).ToArray();

            // Act
            Action action = () => new PackOfCards(cards);

            // Assert
            var exception = Assert.ThrowsException<IncorrectCardCountException>(action);
            Assert.AreEqual(cards.Length, exception.CardCount);
            Assert.AreEqual($"Pack of Cards should contain 52 cards. Card Count supplied: {cards.Length}", exception.Message);
        }
    }
}
