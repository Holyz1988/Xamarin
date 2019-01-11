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
	public partial class RelativeLayoutPage : ContentPage
	{
        public RelativeLayoutPage()
        {
            InitializeComponent();

            var layout = new RelativeLayout();
            Content = layout;

            var aquaBoxView = new BoxView { Color = Color.Aqua };
            var silverBoxView = new BoxView { Color = Color.Silver };
            layout.Children.Add(aquaBoxView,
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height * 0.3));

            layout.Children.Add(silverBoxView,
                yConstraint: Constraint.RelativeToView(aquaBoxView, (relativeLayout, element) => element.Height + 20));

		}
	}
}