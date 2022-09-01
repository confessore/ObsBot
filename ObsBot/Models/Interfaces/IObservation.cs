using ObsBot.Models.Enums;

namespace ObsBot.Models.Interfaces;

public interface IObservation
{
    ObservationType ObservationType { get; set; }
}
