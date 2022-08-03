using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3Sizes.Pages
{
    public class ClockFitSize : ContentPage
    {
        Label clockLabel;
        public ClockFitSize()
        {
            clockLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

            };

            
            Content = clockLabel;

            SizeChanged += (object sender, EventArgs args) =>
            {
                if (this.Width > 0)
                {
                    clockLabel.FontSize = this.Width / 6;
                };
            };

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
           {
               clockLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
               return true;
           });
        }
    }
}