using ObsBot.Converters;
using ObsBot.Models.Enums;
using ObsBot.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ObsBot.Models.Abstractions;

[JsonConverter(typeof(ProgressionConverter))]
public abstract class Progression : Entity<string>, IProgression, IEntity<string>
{
    public ProgressionType ProgressionType { get; set; }
    public string? BaseAsset { get; set; }
    public string? TradeAsset { get; set; }
    public decimal? MeanPrice { get; set; }
    public decimal? HighPrice { get; set; }
    public decimal? LowPrice { get; set; }
    public virtual ICollection<Sample>? Samples { get; set; }
    public long? ProgressionStart { get; set; }
    public long? ProgressionEnd { get; set; }
}
