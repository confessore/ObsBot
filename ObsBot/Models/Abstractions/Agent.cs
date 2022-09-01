using ObsBot.Converters;
using ObsBot.Models.Enums;
using ObsBot.Models.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ObsBot.Models.Abstractions;

[JsonConverter(typeof(AgentConverter))]
public abstract class Agent : Entity<string>, IAgent, IEntity<string>
{
    public AgentType AgentType { get; set; }
    public string? Name { get; set; }
    public virtual ICollection<Position>? Positions { get; set; }
}
