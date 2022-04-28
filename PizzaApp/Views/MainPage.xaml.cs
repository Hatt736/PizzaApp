using PizzaApp.ViewModels;

namespace PizzaApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnOrderClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new OrderPage());
	}
}

