using Microsoft.Maui.Controls;

namespace BlazorAppNet8
{
    public partial class BlazorWindow : ContentPage
    {
        public BlazorWindow()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Console.WriteLine("BlazorWindow: OnDisappearing.");
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}