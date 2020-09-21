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
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();
		}
		Random rnd = new Random();
		private async void hide_Clicked(object sender, EventArgs e)
		{
			bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
			await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
			hat1.Opacity = 0;
			hat2.Opacity = 0;
			round1.Opacity = 0;
			round2.Opacity = 0;
			round3.Opacity = 0;
		}

		private async void show_Clicked(object sender, EventArgs e)
		{
			bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
			await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
			hat1.Opacity = 1;
			hat2.Opacity = 1;
			round1.Opacity = 1;
			round2.Opacity = 1;
			round3.Opacity = 1;
		}

		private async void random_Clicked(object sender, EventArgs e)
		{
			bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
			await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
			int r = rnd.Next(0, 255);
			int g = rnd.Next(0, 255);
			int b = rnd.Next(0, 255);
			hat1.BackgroundColor = Color.FromRgb(r, g, b);
			r = rnd.Next(0, 255);
			g = rnd.Next(0, 255);
			b = rnd.Next(0, 255);
			hat2.BackgroundColor = Color.FromRgb(r, g, b);
			r = rnd.Next(0, 255);
			g = rnd.Next(0, 255);
		    b = rnd.Next(0, 255);
			round1.BackgroundColor = Color.FromRgb(r, g, b);
			r = rnd.Next(0, 255);
			g = rnd.Next(0, 255);
			b = rnd.Next(0, 255);
			round2.BackgroundColor = Color.FromRgb(r, g, b);
			r = rnd.Next(0, 255);
			g = rnd.Next(0, 255);
			b = rnd.Next(0, 255);
			round3.BackgroundColor = Color.FromRgb(r, g, b);
		}

		private async void melt_Clicked(object sender, EventArgs e)
		{
			bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
			await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
			hat1.Opacity = 0.75;
			hat2.Opacity = 0.75;
			round1.Opacity = 0.75;
			round2.Opacity = 0.75;
			round3.Opacity = 0.75;
			await Task.Run(() => Thread.Sleep(1000));
			hat1.Opacity = 0.50;
			hat2.Opacity = 0.50;
			round1.Opacity = 0.50;
			round2.Opacity = 0.50;
			round3.Opacity = 0.50;
			await Task.Run(() => Thread.Sleep(1000));
			hat1.Opacity = 0.25;
			hat2.Opacity = 0.25;
			round1.Opacity = 0.25;
			round2.Opacity = 0.25;
			round3.Opacity = 0.25;
			await Task.Run(() => Thread.Sleep(1000));
			hat1.Opacity = 0;
			hat2.Opacity = 0;
			round1.Opacity = 0;
			round2.Opacity = 0;
			round3.Opacity = 0;
			await Task.Run(() => Thread.Sleep(1000));
		}

		private async void turn_Clicked(object sender, EventArgs e)
		{
			bool result = await DisplayAlert("Подтвердить действие", "Вы уверенны что хотите нажать?", "Да", "Нет");
			await DisplayAlert("Уведомление", "Вы выбрали: " + (result ? "Нажать" : "Отменить"), "OK");
			hat1.Rotation = 40;
		}
	}
}
