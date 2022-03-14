using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12Styles.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColoredButtonsPage : ContentPage
    {
        Style defaultButtonStyle;
        public ColoredButtonsPage()
        {
            InitializeComponent();
            defaultButtonStyle = (Style) Resources["btnStyle"];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Resources["btnStyle"] = defaultButtonStyle;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Resources["btnStyle"] = Resources["btnStyle1"];
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Resources["btnStyle"] = Resources["btnStyle2"];
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Resources["btnStyle"] = Resources["btnStyle3"];
        }
    }
}