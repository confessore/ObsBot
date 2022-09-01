using Microsoft.Maui.Controls;
using ObsBot.PageModels;
using ObsBot.Services.Interfaces;

namespace ObsBot.Pages;

partial class HomePage : ContentPage
{
    HomePageModel _pm;

    public HomePage(
        IDefaultService defaultService)
    {
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
