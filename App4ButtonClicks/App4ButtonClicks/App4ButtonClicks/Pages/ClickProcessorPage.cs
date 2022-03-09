using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App4ButtonClicks.Pages
{
    public class ClickProcessorPage : ContentPage
    {
        Random random = new Random();
        Label messageLabel;
        StackLayout logsLayout;
        Button addButton, removeButton;
        public ClickProcessorPage()
        {
            addButton = new Button
            {
                Text = "Add",
                HorizontalOptions = LayoutOptions.Center,
                CornerRadius = 8,
                Margin = new Thickness(8, 2)
            };
            removeButton = new Button
            {
                Text = "Remove",
                HorizontalOptions = LayoutOptions.Center,
                CornerRadius = 8,
                Margin = new Thickness(8, 2)
            };

            logsLayout = new StackLayout
            {
                Spacing = 2,
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
            };
            messageLabel = new Label
            {
                Text = "Welcome Elroy Kanye",
                VerticalOptions = LayoutOptions.End,
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness(12, 0)
            };

            Content = new StackLayout
            {
                Padding = new Thickness(2, 4, 2, 4),
                Children = {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.Center,
                        Children =
                        {
                            addButton, removeButton,
                        },
                    },
                    new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Children = {messageLabel},
                    },
                    new ScrollView
                    {
                        Content = logsLayout
                    },
                }
            };

            addButton.Clicked += Button_Clicked;
            removeButton.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            messageLabel.Text = "";
            
            if(button == addButton)
            {
                logsLayout.Children.Add(new Label
                {
                    Text = "Button clicked at: " + DateTime.Now.ToString("h:mm:ss"),
                    Padding = new Thickness(16, 4),
                    BackgroundColor = Color.FromRgba(random.NextDouble(), random.NextDouble(), random.NextDouble(), random.NextDouble()),
                });
                messageLabel.Text = "Element added";
            } else if(button == removeButton)
            {

                if (logsLayout.Children.ToList().Count > 0) { logsLayout.Children.RemoveAt(0); messageLabel.Text = "Element removed"; }
                else messageLabel.Text = "No element in logs";

            } else
            {
                Console.WriteLine("No action targeted");
            }
            
            
        }
    }
}