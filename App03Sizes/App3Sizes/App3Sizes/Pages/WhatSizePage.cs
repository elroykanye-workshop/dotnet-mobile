﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3Sizes.Pages
{
    public class WhatSizePage : ContentPage
    {
        Label label;
        public WhatSizePage()
        {
            label = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            Content = label;

            SizeChanged += WhatSizePage_SizeChanged;
        }

        private void WhatSizePage_SizeChanged(object sender, EventArgs e)
        {
            label.Text = String.Format("{0} x {1}", Width, Height);
        }
    }
}