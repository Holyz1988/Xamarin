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
	public partial class AbsoluteLayoutCourse : ContentPage
	{
		public AbsoluteLayoutCourse ()
		{
			InitializeComponent ();

            var layout = new AbsoluteLayout();
            Content = layout;

            var aquaBox = new BoxView { BackgroundColor = Color.Aqua };
            layout.Children.Add(aquaBox,
                                new Rectangle(0, 0, 1, 1),
                                AbsoluteLayoutFlags.All);

            var whiteBox = new BoxView { BackgroundColor = Color.White };
            layout.Children.Add(whiteBox
                                , new Rectangle(0.5, 0.1, 100, 100)
                                , AbsoluteLayoutFlags.PositionProportional);

            var silverButton = new Button { BackgroundColor = Color.Silver, Text = "Get Started", TextColor = Color.White };
            layout.Children.Add(silverButton
                                , new Rectangle(1, 1, 1, 50)
                                , AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);
		}
	}
}