using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App13Bitmaps.Pages
{
    public class ResourceBitmapPage1 : ContentPage
    {
        public ResourceBitmapPage1()
        {
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Image
                    {
                        Source = ImageSource.FromResource("App13Bitmaps.Resources.nfs-screen.png")
                    },
                    new Label
                    {
                        Text = "My car in NFS",
                        VerticalTextAlignment = TextAlignment.Center,
                        FontAttributes = FontAttributes.Bold,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                    }
                },
            };
        }
    }
}