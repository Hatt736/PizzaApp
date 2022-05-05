using PizzaApp.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PizzaApp.ViewModels
{
    public class CartPageViewModel : BaseViewModel
    {
        public CartPageViewModel()
        {
            Subtotal = Globals.Subtotal;
        }

        private double subtotal;
        public double Subtotal
        {
            get { return subtotal; }
            set
            {
                subtotal = value;
                OnPropertyChanged();
            }
        }

        private ICommand navigateToCheckoutCommand;
        public ICommand NavigateToCheckoutCommand =>
        navigateToCheckoutCommand ??
        (navigateToCheckoutCommand = new Command(async () => await ExecuteNavigateToCheckoutCommand()));

        private async Task ExecuteNavigateToCheckoutCommand()
        {
            await Shell.Current.GoToAsync(nameof(CheckoutPage));
        }
    }
}
