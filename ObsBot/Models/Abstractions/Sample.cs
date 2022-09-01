using ObsBot.Converters;
using ObsBot.Models.Enums;
using ObsBot.Models.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ObsBot.Models.Abstractions;

[JsonConverter(typeof(SampleConverter))]
public abstract class Sample : Entity<string>, ISample, IEntity<string>
{
    public SampleType SampleType { get; set; }
    public string? BaseAsset { get; set; }
    public string? TradeAsset { get; set; }
    public decimal? MeanPrice { get; set; }
    public decimal? HighPrice { get; set; }
    public decimal? LowPrice { get; set; }
    public virtual ICollection<Observation>? Observations { get; set; }
    public long? SampleStart { get; set; }
    public long? SampleEnd { get; set; }
}
