using App4ButtonClicks.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4ButtonClicks
{
    public partial class App : Application
    {
        const string entryLabelTextKeyname = "EntryLabelText";
        public string EntryLabelText { get; set; }
        public App()
        {
            if(Properties.ContainsKey(entryLabelTextKeyname))
            {
                EntryLabelText = (string) Properties[entryLabelTextKeyname];
            }
            InitializeComponent();

            MainPage = new SimplestKeypadPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
