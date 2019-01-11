using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Grid_1 : ContentPage
	{
		public Grid_1 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            number.Text += button.Text;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Calling", "Calling " + number.Text + " ...", "OK");
        }
    }
}