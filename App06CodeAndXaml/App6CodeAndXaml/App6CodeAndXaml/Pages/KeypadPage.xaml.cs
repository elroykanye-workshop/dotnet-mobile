using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6CodeAndXaml.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KeypadPage : ContentPage
    {
        public KeypadPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            displayLabel.Text += button.Text;
            backButton.IsEnabled = true;
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            if (displayLabel.Text.Length > 0)
            {
                displayLabel.Text = displayLabel.Text.Remove(displayLabel.Text.Length - 1);
                backButton.IsEnabled = displayLabel.Text.Length > 0;
            }
        }
    }
}