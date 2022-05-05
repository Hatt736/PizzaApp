using PizzaApp.ViewModels;

namespace PizzaApp;

public partial class CheckoutPage : ContentPage
{
	public CheckoutPage(CheckoutPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}