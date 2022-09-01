using ObsBot.Models.Enums;

namespace ObsBot.Models.Interfaces;

public interface IProgression
{
    ProgressionType ProgressionType { get; set; }
}
