using ObsBot.Pages;
using ObsBot.Services.Interfaces;
using ObsBot.Shells;
using System.Threading.Tasks;

namespace ObsBot.PageModels;

class DefaultPageModel : BasePageModel
{
    readonly IDefaultService _defaultService;

    public DefaultPageModel(
        IDefaultService defaultService)
    {
        _defaultService = defaultService;
    }

    new public virtual async Task OnAppearingAsync()
    {
        await base.OnAppearingAsync();
        IsBusy = true;
        await _defaultService.RefreshAgentAsync();
        //var caregiver = await _localStorageService.ReadFromFileAsync<Caregiver>("caregiver");
        if (_defaultService.Agent != null)
        {
            await Task.Delay(1000);
            if (App.Current != null)
                App.Current.MainPage = new DefaultShell();
        }
        else
        {
            if (App.Current != null)
                App.Current.MainPage = new WelcomePage(_defaultService);
        }
        IsBusy = false;
    }
}
