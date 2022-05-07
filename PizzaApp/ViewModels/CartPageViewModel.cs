using PizzaApp.Models;
using PizzaApp.Repositories;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PizzaApp.ViewModels
{
    public class CartPageViewModel : BaseViewModel
    {
        ITakeoutRepository _takeoutRepository;

        public CartPageViewModel(ITakeoutRepository takeoutRepository)
        {
            _takeoutRepository = takeoutRepository;

            Subtotal = _takeoutRepository.CurrentOrder.Subtotal;

            CartItems = new ObservableCollection<CartItem>(_takeoutRepository.CurrentOrder.TakeOutOrderList);
        }

        private ObservableCollection<CartItem> cartItems;
        public ObservableCollection<CartItem> CartItems
        {
            get { return cartItems; }
            set
            {
                cartItems = value;
                OnPropertyChanged();
            }
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
