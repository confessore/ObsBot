using Microsoft.Maui.Controls;

namespace ObsBot.Pages;

partial class AboutPage
{
    void Build()
    {
        Content = new StackLayout
        {
            Children =
            {
                new Label() { Text = "about" }
            }
        };
    }
}
