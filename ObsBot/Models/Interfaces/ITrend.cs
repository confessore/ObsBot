using ObsBot.Models.Enums;

namespace ObsBot.Models.Interfaces;

public interface ITrend
{
    TrendType TrendType { get; set; }
}
