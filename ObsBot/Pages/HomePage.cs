using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;

namespace ObsBot.Pages;

partial class HomePage
{
    void Build()
    {
        Content = DefaultStackLayout();
    }

    StackLayout DefaultStackLayout()
    {
        return new()
        {
            Children = {
                new StackLayout()
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children =
                    {
                        new Label() { Text = "home" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .CenterHorizontal()
                    }
                },
                new StackLayout()
                {
                    VerticalOptions = LayoutOptions.StartAndExpand,
                    Children =
                    {
                        new Label()
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .CenterHorizontal()
                            .Bind(Label.TextProperty, nameof(_pm.Greeting)),
                        new Button() { Text = "status" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .Bind(Button.CommandProperty, nameof(_pm.StatusCommand)),
                        new Button() { Text = "groups", IsEnabled = false}
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5),
                        new Button() { Text = "settings" }
                            .Margins(5, 5, 5, 5)
                            .Paddings(5, 5, 5, 5)
                            .Bind(Button.CommandProperty, nameof(_pm.SettingsCommand)),
                    }
                },
                new StackLayout()
                {
                    VerticalOptions = LayoutOptions.End,
                    Children =
                    {

                    }
                }
            }
        };
    }
}
