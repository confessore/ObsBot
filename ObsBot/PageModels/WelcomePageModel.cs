using Microsoft.Maui.Controls;
using ObsBot.Models.Agents;
using ObsBot.Models.Enums;
using ObsBot.Services.Interfaces;
using ObsBot.Shells;
using System;

namespace ObsBot.PageModels;

class WelcomePageModel : BasePageModel
{
    readonly IDefaultService _defaultService;

    public WelcomePageModel(
        IDefaultService defaultService)
    {
        _defaultService = defaultService;
        ConfirmCommand = new Command(ConfirmAsync);
    }

    string? name;
    public string? Name
    {
        get => name;
        set
        {
            name = value;
            OnPropertyChanged();
        }
    }

    public Command? ConfirmCommand { get; }

    async void ConfirmAsync()
    {
        IsBusy = true;
        var agent = new DefaultAgent()
        {
            Id = Guid.NewGuid().ToString(),
            CreatedAt = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds(),
            AgentType = AgentType.Default,
            Name = Name
        };
        await _defaultService.UpsertAgentAsync(agent);
        if (App.Current != null)
            App.Current.MainPage = new DefaultShell();
        IsBusy = false;
    }
}
