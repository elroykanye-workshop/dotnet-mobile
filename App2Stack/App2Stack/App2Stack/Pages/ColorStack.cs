using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2Stack.Pages
{
    public class ColorStack : ContentPage
    {
        public ColorStack()
        {



            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.SaddleBrown,
                Spacing = 0,

                HorizontalOptions = LayoutOptions.Start,
            };

            Type colorType = typeof(Color);
            Dictionary<string, object> colors = new Color().GetType()
                .GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public)
                .Where(f => f.FieldType == typeof(Color))
                .ToDictionary(f => f.Name, f => f.GetValue(null));

            foreach (var color in colors)
            {
                layout.Children.Add(new Label
                {
                    Text = color.Key,
                    BackgroundColor = (Color) color.Value,
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 18,
                    HorizontalTextAlignment = TextAlignment.Start,
                    VerticalTextAlignment = TextAlignment.Center,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                });
            }



            Content = new ScrollView
            {
                Content = layout,
                BackgroundColor = Color.RosyBrown,
            };
        }
    }
}