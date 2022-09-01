using Microsoft.Maui.Controls;

namespace ObsBot.Pages;

partial class SettingsPage
{
    void Build()
    {
        Content = new StackLayout()
        {
            Children = 
            {
                new Label() { Text = "settings" }
            }
        };
    }
}
