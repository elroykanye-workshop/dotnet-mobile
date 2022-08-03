using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App4ButtonClicks.Pages
{
    public class SimplestKeypadPage : ContentPage
    {
        App app = Application.Current as App;
        Label entryLabel, messageLabel;
        Button[] buttons = new Button[]
        {
            new Button {Text = "0"},
            new Button {Text = "1"},
            new Button {Text = "2"},
            new Button {Text = "3"},
            new Button {Text = "4"},
            new Button {Text = "5"},
            new Button {Text = "6"},
            new Button {Text = "7"},
            new Button {Text = "8"},
            new Button {Text = "9"},
        };
        Button backButton = new Button { Text = "<-", };
        public SimplestKeypadPage()
        {
            entryLabel = new Label { Text = app.EntryLabelText, HorizontalTextAlignment = TextAlignment.End };
            messageLabel = new Label { Text = "", HorizontalTextAlignment = TextAlignment.Center };
            Content = new StackLayout
            {
                Padding = new Thickness(16, 24),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    entryLabel,
                    backButton,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            buttons[1],
                            buttons[2],
                            buttons[3],
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            buttons[4],
                            buttons[5],
                            buttons[6],
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            buttons[7],
                            buttons[8],
                            buttons[9],
                        }
                    },
                    buttons[0],
                    messageLabel,
                }
            };

            backButton.Clicked += BackButton_Clicked;
            backButton.IsEnabled = entryLabel.Text != null && entryLabel.Text.Length > 0;
            foreach(Button button in buttons)
            {
                button.Clicked += Button_Clicked;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            Button button = (Button)sender;
            entryLabel.Text = entryLabel.Text + button.Text;
            app.EntryLabelText = entryLabel.Text;

            backButton.IsEnabled = true;
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            if(entryLabel.Text.Length > 0)
            {
                messageLabel.Text = "";
                entryLabel.Text = entryLabel.Text.Remove(entryLabel.Text.Length - 1, 1);
            }
            else
            {
                messageLabel.Text = "Cannot delete empty text";
            }
            backButton.IsEnabled = entryLabel.Text.Length > 0;
            app.EntryLabelText = entryLabel.Text;
        }
    }
}