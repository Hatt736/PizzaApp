using PizzaApp.ViewModels;

namespace PizzaApp.Views;

public partial class CartPage : ContentPage
{
	public CartPage(CartPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}

    private void Close_Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
	}
}