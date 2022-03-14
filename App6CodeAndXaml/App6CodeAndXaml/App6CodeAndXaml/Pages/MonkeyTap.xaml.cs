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
    public partial class MonkeyTap : ContentPage
    {
        const int sequenceTime = 3000;
        protected const int flashDuration = 1000;

        const double onLuminousity = 0.8;
        const double offLuminousity = 0.2;

        BoxView[] boxViews;
        Color[] colors = {Color.Red, Color.Green, Color.Blue, Color.Yellow};
        List<int> sequence = new List<int>();
        int sequenceIndex;
        bool awaitingTaps;
        bool gameEnded;
        Random random = new Random();
        public MonkeyTap()
        {
            InitializeComponent();
            boxViews = new BoxView[] { boxView1, boxView2, boxView3, boxView4 };
            InitializeBoxViewColors();
        }

        private void StartButton_Clicked(object sender, EventArgs e)
        {
            gameEnded = false; startButton.IsVisible = false;
            InitializeBoxViewColors();
            sequence.Clear();
            StartSequence();
        }

        private void InitializeBoxViewColors()
        {
            for(int i = 0; i < colors.Length; i++)
            {
                boxViews[i].Color = colors[i].WithLuminosity(offLuminousity);
            }
        }

        private void BoxView_Tapped(object sender, EventArgs e)
        {
            if (gameEnded) return;
            if(!awaitingTaps)
            {
                EndGame();
                return;
            }

            var tappedBoxView = (BoxView)sender;
            int index = Array.IndexOf(boxViews, tappedBoxView);
            if(index != sequence[sequenceIndex])
            {
                Console.WriteLine(index + " : " + sequence[sequenceIndex]);
                EndGame();
                return;
            }
            FlashBoxView(index);
            sequenceIndex++;
            awaitingTaps = sequenceIndex < sequence.Count;
            if (!awaitingTaps) StartSequence();
        }

        protected virtual void EndGame()
        {

            gameEnded = true;
            foreach(var box in boxViews)
            {
                box.Color = Color.Gray;
            }
            startButton.Text = "Try again?";
            startButton.IsVisible = true;
        }

        

        private void StartSequence()
        {
            sequence.Add(random.Next(4));
            sequenceIndex = 0;
            Device.StartTimer(TimeSpan.FromSeconds(sequenceTime), OnTimerTick);
        }

        private bool OnTimerTick()
        {
            if (gameEnded) return false;
            FlashBoxView(sequence[sequenceIndex]);
            sequenceIndex++;
            awaitingTaps = sequence.Count == sequenceIndex;
            sequenceIndex = awaitingTaps ? 0 : sequenceIndex;
            return !awaitingTaps;
        }

        private void FlashBoxView(int v)
        {
            boxViews[v].Color = colors[v].WithLuminosity(onLuminousity);
            Device.StartTimer(TimeSpan.FromSeconds(flashDuration), () =>
            {
                if (gameEnded) return false;
                boxViews[v].Color = colors[v].WithLuminosity(offLuminousity);
                return false;
            });
        }
    }
}