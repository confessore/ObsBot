using ObsBot.Models.Enums;

namespace ObsBot.Models.Interfaces;

public interface ISample
{
    SampleType SampleType { get; set; }
}
