using System;
using CardGame.Domain.Enums;

namespace CardGame.Domain.Interfaces
{
    public interface ICard : IEquatable<ICard>
    {
        Suit Suit { get; set; }
        Value Value { get; set; }
    }
}
