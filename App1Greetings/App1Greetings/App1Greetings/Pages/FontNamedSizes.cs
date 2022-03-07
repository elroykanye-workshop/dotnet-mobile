using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1Greetings.Pages
{
    public class FontNamedSizes : ContentPage
    {
        public void SortNamedSizes(NamedSize[] namedSizes)
        {
            for(int i = 0; i < namedSizes.Length - 1; i++)
            {
                for(int j = i + 1; j < namedSizes.Length; j++)
                {
                    if(Device.GetNamedSize(namedSizes[j], typeof(Label)) < Device.GetNamedSize(namedSizes[i], typeof(Label))) 
                    {
                        var temp = namedSizes[j];
                        namedSizes[j] = namedSizes[i];
                        namedSizes[i] = temp;
                    }
                }
            }
        }
        public FontNamedSizes()
        {
            FormattedString formattedString = new FormattedString();
            NamedSize[] namedSizes = new NamedSize[]
            {
                NamedSize.Header, NamedSize.Title, NamedSize.Subtitle, NamedSize.Body, NamedSize.Caption, 
                NamedSize.Micro, NamedSize.Small, NamedSize.Medium,  NamedSize.Large, NamedSize.Default, 
            };

            SortNamedSizes(namedSizes);


            foreach(var namedSize in namedSizes)
            {
                var fontSize = Device.GetNamedSize(namedSize, typeof(Label));
                formattedString.Spans.Add(new Span
                {
                    Text = String.Format("Named Size = {0} : {1:F2}", namedSize, fontSize),
                });

                if(namedSize != namedSizes.Last())
                {
                    formattedString.Spans.Add(new Span
                    {
                        Text = Environment.NewLine + Environment.NewLine,
                    });
                }
            }
            Content = new Label
            {
                FormattedText = formattedString,
                BackgroundColor = Color.FromRgba(0.25, 0.34, 0.25, 0.25),
                TextColor = Color.DarkSlateBlue,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            };
        }
    }
}