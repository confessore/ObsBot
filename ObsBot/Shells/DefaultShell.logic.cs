using Microsoft.Maui.Controls;
using ObsBot.ShellModels;

namespace ObsBot.Shells;

public partial class DefaultShell : Shell
{
    DefaultShellModel _sm;

    public DefaultShell()
    {
        BindingContext = _sm = new DefaultShellModel();
        Build();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}
