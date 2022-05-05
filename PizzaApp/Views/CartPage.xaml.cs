using PizzaApp.ViewModels;

namespace PizzaApp.Views;

public partial class CartPage : ContentPage
{
	public CartPage(CartPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}