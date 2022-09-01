using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using ObsBot.PageModels;

namespace ObsBot.Pages;

partial class AboutPage : ContentPage
{
    AboutPageModel _pm;

    public AboutPage()
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
