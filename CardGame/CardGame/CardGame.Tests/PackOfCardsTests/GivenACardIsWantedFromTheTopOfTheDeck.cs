using System;
using CardGame.Domain;
using CardGame.Domain.Exceptions;
using CardGame.Domain.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardGame.Tests.PackOfCardsTests
{
    [TestClass]
    public class GivenACardIsWantedFromTheTopOfTheDeck : PackOfCardsBaseTest
    {
        private IPackOfCards _packOfCardsUnderTest;

        [TestInitialize]
        public void TestInitialize()
        {
            _packOfCardsUnderTest = new PackOfCards(GetCards());
        }

        [TestMethod]
        public void WhenACardIsTaken_ThenTheCountShouldDecreaseBy1()
        {
            // Arrange
            var topCardFromSetupDeck = GetCards()[0];

            // Act
            var card = _packOfCardsUnderTest.TakeCardFromTopOfPack();

            // Assert
            Assert.IsTrue(card.Equals(topCardFromSetupDeck));
            Assert.AreEqual(51, _packOfCardsUnderTest.Count);
        }

        [TestMethod]
        public void When52CardsHaveBeenTakenFromTheDeckAndYouTryToTake1More_ThenThrowsPackOfCardsEmptyException()
        {
            // Arrange
            for (int i = 0; i < 52; i++)
            {
                _packOfCardsUnderTest.TakeCardFromTopOfPack();
            }

            // Act
            Action action = () => _packOfCardsUnderTest.TakeCardFromTopOfPack();

            // Assert
            var exception = Assert.ThrowsException<PackOfCardsEmptyException>(action);
            Assert.AreEqual("No cards left to take from the top.", exception.Message);
        }

        [TestMethod]
        public void When52CardsHaveBeenTakenFromTheDeck_ThenCountShouldReturn0()
        {
            // Arrange
            for (int i = 0; i < 52; i++)
            {
                _packOfCardsUnderTest.TakeCardFromTopOfPack();
            }

            // Act
            var actualCount = _packOfCardsUnderTest.Count;

            // Assert
            Assert.AreEqual(0, actualCount);
        }
    }
}
