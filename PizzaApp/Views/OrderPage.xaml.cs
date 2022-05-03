using PizzaApp.Repositories;
using PizzaApp.ViewModels;

namespace PizzaApp.Views;


public partial class OrderPage : ContentPage
{
    public OrderPage(OrderPageViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }

    //private async void OnCartClick(object sender, EventArgs e)
    //{
    //    var page = new CartPage();
    //    page.BindingContext = new CartPageViewModel(new PizzaRepository());
    //    //await Navigation.PushAsync<OrderPage>();
    //    await Navigation.PushAsync(page);

    //}
}