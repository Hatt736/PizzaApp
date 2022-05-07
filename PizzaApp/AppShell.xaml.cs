using PizzaApp.Views;

using System.Windows.Input;

namespace PizzaApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        BindingContext = this;

        quantity = 0;

      //  ItemsQuantity.Text= quantity.ToString();

        Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
        Routing.RegisterRoute(nameof(CheckoutPage), typeof(CheckoutPage));
        Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));
        Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage));
    }

    int quantity;

    private bool isFlyoutOpen;
    public bool IsFlyoutOpen
    {
        get { return isFlyoutOpen; }
        set
        {
            isFlyoutOpen = value;
            OnPropertyChanged();
        }
    }

    private ICommand closeFlyoutCommand;
    public ICommand CloseFlyoutCommand =>
        closeFlyoutCommand ??
        (closeFlyoutCommand = new Command<object>((x) => ExecuteCloseFlyoutCommand(x)));

    private void ExecuteCloseFlyoutCommand(object x)
    {
        IsFlyoutOpen = false;
    }

    //private async void Cart_Clicked(object sender, EventArgs e)
    //{
    //    quantity++;

    //    ItemsQuantity.Text= quantity.ToString();

    //    await Shell.Current.GoToAsync(nameof(CartPage));
    //}
}
