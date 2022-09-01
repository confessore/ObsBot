using ObsBot.Converters;
using ObsBot.Models.Enums;
using ObsBot.Models.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ObsBot.Models.Abstractions;

[JsonConverter(typeof(ObservationConverter))]
public abstract class Observation : Entity<string>, IObservation, IEntity<string>
{
    public ObservationType ObservationType { get; set; }
    public string? BaseAsset { get; set; }
    public string? TradingAsset { get; set; }
    public decimal? Price { get; set; }
    public long? ObservedAt { get; set; }
}
