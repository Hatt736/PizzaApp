using PizzaApp.Views;

namespace PizzaApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("orderpage", typeof(OrderPage));
    }
}
