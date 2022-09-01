using ObsBot.Models.Enums;

namespace ObsBot.Models.Interfaces;

public interface IPosition
{
    PositionType PositionType { get; set; }
}
