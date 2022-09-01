using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using ObsBot.Services.Interfaces;
using System;

namespace ObsBot;

public partial class App : Application
{
    readonly IServiceProvider _serviceProvider;

    public App(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        Build();
    }

    protected override void OnStart()
    {

    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }

    IDefaultService DefaultService =>
        _serviceProvider.GetRequiredService<IDefaultService>();
}
