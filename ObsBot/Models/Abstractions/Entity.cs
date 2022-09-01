using ObsBot.Models.Interfaces;
using System;

namespace ObsBot.Models.Abstractions;

public abstract class Entity<TKey> : IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    public TKey? Id { get; set; }
    public long? CreatedAt { get; set; }
}
