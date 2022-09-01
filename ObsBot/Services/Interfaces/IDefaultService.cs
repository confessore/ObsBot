using ObsBot.Models.Abstractions;
using System.Threading.Tasks;

namespace ObsBot.Services.Interfaces;

public interface IDefaultService
{
    public Agent? Agent { get; }

    Task RefreshAgentAsync();
    Task UpsertAgentAsync(Agent agent);
}
