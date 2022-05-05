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
}