using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App13Bitmaps.Pages
{
    public class GithubImagePage : ContentPage
    {
        public GithubImagePage()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Image
                    {
                        Source = ImageSource.FromUri(new Uri("https://avatars.githubusercontent.com/u/77556066?v=4")),

                    },
                    new Label
                    {
                        Text = "Elroy Vince!",
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontAttributes = FontAttributes.Bold,
                    }
                }
            };
        }
    }
}