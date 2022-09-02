using ObsBot.Converters;
using ObsBot.Models.Enums;
using ObsBot.Models.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ObsBot.Models.Abstractions;

[JsonConverter(typeof(TrendConverter))]
public abstract class Trend : Entity<string>, ITrend, IEntity<string>
{
    public TrendType TrendType { get; set; }
    public string? BaseAsset { get; set; }
    public string? TradeAsset { get; set; }
    public decimal? MeanPrice { get; set; }
    public decimal? HighPrice { get; set; }
    public decimal? LowPrice { get; set; }
    public virtual ICollection<Progression>? Progressions { get; set; }
}
