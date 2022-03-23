using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App13Bitmaps.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResourceBitmapPage2 : ContentPage
    {
        Label label;
        public ResourceBitmapPage2()
        {
            InitializeComponent();
            label = imageSizeLabel;
            
        }

        private void Image_SizeChanged(object sender, EventArgs e)
        {
            Image image = (Image)sender;
            label.Text = String.Format("{0} x {1}", image.Width, image.Height);

        }
    }
}