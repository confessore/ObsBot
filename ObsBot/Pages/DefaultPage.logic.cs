using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using ObsBot.PageModels;
using ObsBot.Services.Interfaces;

namespace ObsBot.Pages;

partial class DefaultPage : ContentPage
{
    DefaultPageModel _pm;

    public DefaultPage(
        IDefaultService defaultService)
    {
        On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        BindingContext = _pm = new(defaultService);
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}
