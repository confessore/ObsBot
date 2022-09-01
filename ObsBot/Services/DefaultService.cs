using ObsBot.Models.Abstractions;
using ObsBot.Services.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace ObsBot.Services;

public class DefaultService : IDefaultService
{
	readonly ILiteDBService<Agent, string> _agentDBService;

	public DefaultService(
        ILiteDBService<Agent, string> agentDBService)
	{
		_agentDBService = agentDBService;
	}

	Agent? agent;
	public Agent? Agent
	{
		get => agent;
		set
		{
			agent = value;
		}
	}

	public async Task RefreshAgentAsync()
	{
		var agents = await _agentDBService.FindAllAsync();
		Agent = agents.FirstOrDefault();
	}

	public async Task UpsertAgentAsync(Agent agent) =>
		await _agentDBService.UpsertAsync(agent);
}
