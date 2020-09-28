using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lumememm1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		BoxView head,hat1, hat2, eye1, eye2, eyebrows, lips, body1, body2;
		Button btn1, btn2, btn3, btn4, btn5;
		public Page2()
		{
			AbsoluteLayout abs = new AbsoluteLayout();

			head = new BoxView { Color = Color.LightBlue,CornerRadius = 90 };
			AbsoluteLayout.SetLayoutBounds(head, new Rectangle(0.5,0.15, 50, 50));
			AbsoluteLayout.SetLayoutFlags(head, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(head);

			body1 = new BoxView { Color = Color.Blue, CornerRadius = 90 };
			AbsoluteLayout.SetLayoutBounds(body1, new Rectangle(0.5,0.27, 100, 100));
			AbsoluteLayout.SetLayoutFlags(body1, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(body1);

			body2 = new BoxView { Color = Color.DarkBlue, CornerRadius = 90 };
			AbsoluteLayout.SetLayoutBounds(body2, new Rectangle(0.5, 0.53, 150, 150));
			AbsoluteLayout.SetLayoutFlags(body2, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(body2);

			hat1 = new BoxView { Color = Color.Black };
			AbsoluteLayout.SetLayoutBounds(hat1, new Rectangle(0.5, 0.05, 30, 52));
			AbsoluteLayout.SetLayoutFlags(hat1, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(hat1);

			hat2 = new BoxView { Color = Color.Black };
			AbsoluteLayout.SetLayoutBounds(hat2, new Rectangle(0.5, 0.13, 80, 5));
			AbsoluteLayout.SetLayoutFlags(hat2, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(hat2);

			eye1 = new BoxView { Color = Color. Red, CornerRadius = 90 };
			AbsoluteLayout.SetLayoutBounds(eye1, new Rectangle(0.47, 0.17, 10, 10));
			AbsoluteLayout.SetLayoutFlags(eye1, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(eye1);

			eye2 = new BoxView { Color = Color.Red, CornerRadius = 90 };
			AbsoluteLayout.SetLayoutBounds(eye2, new Rectangle(0.53, 0.17, 10, 10));
			AbsoluteLayout.SetLayoutFlags(eye2, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(eye2);

			eyebrows = new BoxView { Color = Color.SaddleBrown };
			AbsoluteLayout.SetLayoutBounds(eyebrows, new Rectangle(0.50, 0.15, 30, 7));
			AbsoluteLayout.SetLayoutFlags(eyebrows, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(eyebrows);

			lips = new BoxView { Color = Color.DarkRed, CornerRadius = 90 };
			AbsoluteLayout.SetLayoutBounds(lips, new Rectangle(0.50, 0.20, 12, 25));
			AbsoluteLayout.SetLayoutFlags(lips, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(lips);

			btn1 = new Button { Text = "Спрятать", BackgroundColor = Color.Pink };
			btn1.Clicked += Btn1_Clicked;
			AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(0.5, 0.8, 100, 80));
			AbsoluteLayout.SetLayoutFlags(btn1, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(btn1);

			btn2 = new Button { Text = "Показать", BackgroundColor = Color.Blue };
			btn2.Clicked += Btn2_Clicked;
			AbsoluteLayout.SetLayoutBounds(btn2, new Rectangle(0.05, 0.8, 100, 80));
			AbsoluteLayout.SetLayoutFlags(btn2, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(btn2);

			btn3 = new Button { Text = "Случайно", BackgroundColor = Color.MediumPurple };
			btn3.Clicked += Btn3_Clicked;
			AbsoluteLayout.SetLayoutBounds(btn3, new Rectangle(1, 0.8, 100, 80));
			AbsoluteLayout.SetLayoutFlags(btn3, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(btn3);

			btn4 = new Button { Text = "Растопить", BackgroundColor = Color.Yellow };
			btn4.Clicked += Btn4_Clicked;
			AbsoluteLayout.SetLayoutBounds(btn4, new Rectangle(0.1000, 1, 110, 80));
			AbsoluteLayout.SetLayoutFlags(btn4, AbsoluteLayoutFlags.PositionProportional);
			abs.Children.Add(btn4);

			Content = abs;
		}

		private async void Btn4_Clicked(object sender, EventArgs e)
		{
			if (flag)
			{
				bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
				await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
				hat1.Opacity = 0.75;
				hat2.Opacity = 0.75;
				head.Opacity = 0.75;
				body1.Opacity = 0.75;
				body2.Opacity = 0.75;
				lips.Opacity = 0.75;
				eye1.Opacity = 0.75;
				eye2.Opacity = 0.75;
				eyebrows.Opacity = 0.75;
				await Task.Run(() => Thread.Sleep(1000));
				hat1.Opacity = 0.50;
				hat2.Opacity = 0.50;
				head.Opacity = 0.50;
				body1.Opacity = 0.50;
				body2.Opacity = 0.50;
				lips.Opacity = 0.50;
				eye1.Opacity = 0.50;
				eye2.Opacity = 0.50;
				eyebrows.Opacity = 0.50;
				await Task.Run(() => Thread.Sleep(1000));
				hat1.Opacity = 0.25;
				hat2.Opacity = 0.25;
				head.Opacity = 0.25;
				body1.Opacity = 0.25;
				body2.Opacity = 0.25;
				lips.Opacity = 0.25;
				eye1.Opacity = 0.25;
				eye2.Opacity = 0.25;
				eyebrows.Opacity = 0.25;
				await Task.Run(() => Thread.Sleep(1000));
			hat1.Opacity = 0;
				hat2.Opacity = 0;
				head.Opacity = 0;
				body1.Opacity = 0;
				body2.Opacity = 0;
				lips.Opacity = 0;
				eye1.Opacity = 0;
				eye2.Opacity = 0;
				eyebrows.Opacity = 0;
				await Task.Run(() => Thread.Sleep(1000));
				flag = true;
			}
			else 
			{
				hat1.Opacity = 0;
				hat2.Opacity = 0;
				head.Opacity = 0;
				body1.Opacity = 0;
				body2.Opacity = 0;
				eye1.Opacity = 0;
				eye2.Opacity = 0;
				eyebrows.Opacity = 0;
				lips.Opacity = 0;
				flag = false;
			}
		}

		Random rnd = new Random();
		private void Btn3_Clicked(object sender, EventArgs e)
		{
			if (flag)
			{
				int r = rnd.Next(0, 255);
				int g = rnd.Next(0, 255);
				int b = rnd.Next(0, 255);
				head.Color = Color.FromRgb(r, g, b);
				r = rnd.Next(0, 255);
				g = rnd.Next(0, 255);
				b = rnd.Next(0, 255);
				body1.Color = Color.FromRgb(r, g, b);
				r = rnd.Next(0, 255);
				g = rnd.Next(0, 255);
				b = rnd.Next(0, 255);
				body2.Color = Color.FromRgb(r, g, b);
				r = rnd.Next(0, 255);
				g = rnd.Next(0, 255);
				b = rnd.Next(0, 255);
				flag = true;
			}
		}

		private void Btn2_Clicked(object sender, EventArgs e)
		{
			if (flag)
			{
				hat1.Opacity = 1;
				hat2.Opacity = 1;
				head.Opacity = 1;
				body1.Opacity = 1;
				body2.Opacity = 1;
				eye1.Opacity = 1;
				eye2.Opacity = 1;
				eyebrows.Opacity = 1;
				lips.Opacity = 1;
				flag = true;
			}
		}

		bool flag = true;
		private void Btn1_Clicked(object sender, EventArgs e)
		{
			if (flag)
			{
				hat1.Opacity = 0;
				hat2.Opacity = 0;
				head.Opacity = 0;
				body1.Opacity = 0;
				body2.Opacity = 0;
				eye1.Opacity = 0;
				eye2.Opacity = 0;
				eyebrows.Opacity = 0;
				lips.Opacity = 0;
				flag = true;
			}
		}
	}
}