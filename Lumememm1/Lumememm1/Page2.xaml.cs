using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		BoxView head, eye1, eye2, lips, body1, body2;
		public Page2()
		{
			AbsoluteLayout abs = new AbsoluteLayout();

			head = new BoxView { Color = Color.LightBlue,CornerRadius = 100 };
			AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.5,0.25, 90, 90));
			AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(head);

			body1 = new BoxView { Color = Color.Blue, CornerRadius = 100 };
			AbsoluteLayout.SetLayoutBounds(body1, new Rectangle(0.5,0.50, 150, 150));
			AbsoluteLayout.SetLayoutFlags(body1, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(body1);

			body2 = new BoxView { Color = Color.DarkBlue, CornerRadius = 100 };
			AbsoluteLayout.SetLayoutBounds(body2, new Rectangle(0.5, 0.95,180, 180));
			AbsoluteLayout.SetLayoutFlags(body2, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(body2);

			Content = abs;
		}
	}
}