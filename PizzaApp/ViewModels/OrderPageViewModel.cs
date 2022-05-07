using PizzaApp.Models;
using PizzaApp.Repositories;
using PizzaApp.Views;

using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PizzaApp.ViewModels
{
    public class OrderPageViewModel : BaseViewModel
    {
        ITakeoutRepository _takeoutRepository;

        public OrderPageViewModel(ITakeoutRepository takeoutRepository)
        {
            _takeoutRepository = takeoutRepository;

            GroupedTakeoutCollection = new ObservableCollection<TakeoutItemCategoryGroup>(_takeoutRepository.CreateGroupedMenuItemsCollection());

            Toppings = new ObservableCollection<Topping>(_takeoutRepository.CreateToppingCollection());
        }

        public ObservableCollection<TakeoutItemCategoryGroup> GroupedTakeoutCollection { get; set; }
        public ObservableCollection<Topping> Toppings { get; set; }

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


        private object selectedItem;
        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }


        private ICommand selectItemCommand;
        public ICommand SelectItemCommand =>
        selectItemCommand ??
        (selectItemCommand = new Command<object>(async (x) => await ExecuteSelectItemCommand(x)));

        private async Task ExecuteSelectItemCommand(object selection)
        {
            //if (selection == null)
            //    return;

            // var selectedItem = selection as TakeoutMenuItem;

            //  selection = null;

            if (SelectedItem == null)
                return;

            var selectedItem = SelectedItem as TakeoutMenuItem;

            string name = selectedItem.Name;

            double price = selectedItem.Price;

            CalculateQuanities(name, price);

            Subtotal = AddSubTotal();

            _takeoutRepository.CurrentOrder.Subtotal = Subtotal;

            await Task.Delay(100);

            SelectedItem = null;
        }

        private void CalculateQuanities(string name, double price)
        {
            foreach (var item in _takeoutRepository.CurrentOrder.TakeOutOrderList)
            {
                if (item.Name == name)
                {
                    item.Quanity++;
                    item.Price += price;

                    return;
                }
            }

            _takeoutRepository.CurrentOrder.TakeOutOrderList.Add(new CartItem(name, price, 1));
        }

        private double AddSubTotal()
        {
            double amount = 0.00;

            foreach (var item in _takeoutRepository.CurrentOrder.TakeOutOrderList)
            {
                amount += item.Price;
            }

            return amount;
        }

        private ICommand navigateToCartCommand;
        public ICommand NavigateToCartCommand =>
        navigateToCartCommand ??
        (navigateToCartCommand = new Command(async () => await ExecuteNavigateToCartCommand()));

        private async Task ExecuteNavigateToCartCommand()
        {
            await Shell.Current.GoToAsync(nameof(CartPage));
        }


        //private bool shoppingCartVisible;
        //public bool ShoppingCartVisible
        //{
        //    get { return shoppingCartVisible; }
        //    set
        //    {
        //        shoppingCartVisible = value;
        //        OnPropertyChanged();
        //    }
        //}

        private ICommand navigateToCartPageCommand;
        public ICommand NavigateToCartPageCommand =>
        navigateToCartPageCommand ??
        (navigateToCartPageCommand = new Command<object>(async (x) => await ExecuteNavigateToCartPageCommand(x)));

        private async Task ExecuteNavigateToCartPageCommand(object obj)
        {
            await Shell.Current.GoToAsync(nameof(CartPage));
        }

    }
}

