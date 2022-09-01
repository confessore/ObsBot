using ObsBot.Converters;
using ObsBot.Models.Enums;
using ObsBot.Models.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ObsBot.Models.Abstractions;

[JsonConverter(typeof(PositionConverter))]
public abstract class Position : Entity<string>, IPosition, IEntity<string>
{
    public PositionType PositionType { get; set; }
    public string? BaseAsset { get; set; }
    public string? TradeAsset { get; set; }
    public decimal? BuyPrice { get; set; }
    public decimal? SellPrice { get; set; }
    public long? PurchasedAt { get; set; }
    public long? ExpiresAt { get; set; }
}
