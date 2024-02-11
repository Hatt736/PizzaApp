using PizzaApp.Repositories;
using PizzaApp.ViewModels;

namespace PizzaApp.Views;

public partial class MainPage : ContentPage
{
	public MainPage()//MainPageViewModel vm)
	{
		InitializeComponent();

		//BindingContext = vm;
	}

	//private async void OnOrderClicked(object sender, EventArgs e)
	//{
	//	var page = new OrderPage();
	//	page.BindingContext = new OrderPageViewModel(new TakeoutRepository());
	//	//await Navigation.PushAsync<OrderPage>();
	//	await Navigation.PushAsync(page);
	//}
	private async void OnSettingsClicked(object sender, EventArgs e)
	{
		var page = new SettingsPage();
		//page.BindingContext = new OrderPageViewModel(new PizzaRepository());
		//await Navigation.PushAsync<OrderPage>();

		//await Navigation.PushAsync(page);
	}
}

