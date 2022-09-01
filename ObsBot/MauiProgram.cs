using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using ObsBot.Models.Abstractions;
using ObsBot.Pages;
using ObsBot.Services;
using ObsBot.Services.Interfaces;
using ObsBot.Shells;

namespace ObsBot;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        builder.Services.AddScoped<ILocalStorageAccessService, LocalStorageAccessService>();
        builder.Services.AddScoped<ILiteDBService<Agent, string>, LiteDBService<Agent, string>>();
        builder.Services.AddSingleton<IDefaultService, DefaultService>();
        builder.Services.AddTransient<DefaultShell>();
        builder.Services.AddTransient<DefaultPage>();
        builder.Services.AddTransient<HomePage>();
        return builder.Build();
    }
}
