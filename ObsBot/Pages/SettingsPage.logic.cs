using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using ObsBot.PageModels;

namespace ObsBot.Pages;

partial class SettingsPage : ContentPage
{
    SettingsPageModel _pm;

    public SettingsPage()
    {
        On<Microsoft.Maui.Controls.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        BindingContext = _pm = new();
        Build();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pm.OnAppearingAsync();
        Title = _pm.Title;
    }
}