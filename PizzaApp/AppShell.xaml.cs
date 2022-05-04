using PizzaApp.Views;

using System.Windows.Input;

namespace PizzaApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        BindingContext = this;

        Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));
        Routing.RegisterRoute(nameof(CheckoutPage), typeof(CheckoutPage));
        Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage));
    }

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
}
