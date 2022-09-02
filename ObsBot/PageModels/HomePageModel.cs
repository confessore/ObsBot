using Microsoft.Maui.Controls;
using ObsBot.Pages;
using ObsBot.Services.Interfaces;
using System.Threading.Tasks;

namespace ObsBot.PageModels;

class HomePageModel : BasePageModel
{
    readonly IDefaultService _defaultService;

    public HomePageModel(
        IDefaultService defaultService)
    {
        _defaultService = defaultService;
        StatusCommand = new Command(StatusAsync);
        SettingsCommand = new Command(SettingsAsync);
    }

    string? greeting = string.Empty;
    public string? Greeting
    {
        get => greeting;
        set
        {
            greeting = value;
            OnPropertyChanged();
        }
    }

    string? name = string.Empty;
    public string? Name
    {
        get => name;
        set
        {
            name = value;
            Greeting = $"welcome, {name}!";
            OnPropertyChanged();
        }
    }

    public Command? StatusCommand { get; }

    async void StatusAsync()
    {
        IsBusy = true;
        var updated = new HomePage(_defaultService);
        await Shell.Current.Navigation.PopAsync();
        await Shell.Current.Navigation.PushAsync(updated);
        IsBusy = false;
    }

    public Command? SettingsCommand { get; }

    async void SettingsAsync()
    {
        IsBusy = true;
        await Shell.Current.Navigation.PushAsync(new SettingsPage());
        IsBusy = false;
    }

    public override async Task OnAppearingAsync()
    {
        await base.OnAppearingAsync();
        IsBusy = true;
        await _defaultService.RefreshAgentAsync();
        if (_defaultService.Agent != null)
            Name = _defaultService.Agent.Name;
        IsBusy = false;
    }
}
