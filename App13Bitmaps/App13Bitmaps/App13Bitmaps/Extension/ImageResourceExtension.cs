using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App13Bitmaps.Extension
{
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public String Source { get; set; }
        public object ProvideValue (IServiceProvider serviceProvider)
        {
            return Source == null ? null : ImageSource.FromResource(Source);
        }
    }
}
