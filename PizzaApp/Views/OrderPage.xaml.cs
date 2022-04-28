namespace PizzaApp;
using PizzaApp.ViewModels;

public partial class OrderPage : ContentPage
{
    public OrderPage()
    {
        InitializeComponent();

        BindingContext = new OrderPageViewModel();
    }
}