using ObsBot.Models.Enums;

namespace ObsBot.Models.Interfaces;

public interface IAgent
{
    AgentType AgentType { get; set; }
}
