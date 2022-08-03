﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6CodeAndXaml.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorView : ContentView
    {
        string colorName;
        ColorTypeConverter colorTypeConverter = new ColorTypeConverter();
        public ColorView()
        {
            InitializeComponent();
        }

        public string ColorName
        {
            get
            {
                return colorName;
            }
            set
            {
                colorName = value;
                colorNameLabel.Text = value;

                Color color = (Color) colorTypeConverter.ConvertFromInvariantString(colorName);
                boxView.Color = color;
                colorValueLabel.Text = String.Format("{0:X2}-{1:X2}-{2:X2}", (int)(255 * color.R), (int)(255 * color.G), (int)(255 * color.B));
            }
        }
    }
}