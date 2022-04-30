using PizzaApp.Models;
using PizzaApp.Repositories;

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

            CartItems = new ObservableCollection<CartItem>();
        }

        public ObservableCollection<TakeoutItemCategoryGroup> GroupedTakeoutCollection { get; set; }
        public ObservableCollection<Topping> Toppings { get; set; }


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
        (selectItemCommand = new Command<object>((x) => ExecuteSelectItemCommand(x)));

        private void ExecuteSelectItemCommand(object selection)
        {
            if (selection == null)
                return;

            var selectedItem = selection as TakeoutMenuItem;

            selection = null;

            string name = selectedItem.Name;

            double price = selectedItem.Price;

            CalculateQuanities(name, price);

            Subtotal = AddSubTotal();



            SelectedItem = null;
        }

        private void CalculateQuanities(string name, double price)
        {
            foreach (var item in CartItems)
            {
                if (item.Name == name)
                {
                    item.Quanity++;
                    item.Price += price;

                    return;
                }
            }

            CartItems.Add(new CartItem(name, price, 1));
        }

        private double AddSubTotal()
        {
            double amount = 0.00;

            foreach (var item in CartItems)
            {
                amount += item.Price;
            }

            return amount;
        }

        private ICommand toggleCartCommand;
        public ICommand ToggleCartCommand =>
        toggleCartCommand ??
        (toggleCartCommand = new Command(ExecuteToggleCartCommand));

        private void ExecuteToggleCartCommand()
        {
            ShoppingCartVisible = !ShoppingCartVisible;
        }


        private bool shoppingCartVisible;
        public bool ShoppingCartVisible
        {
            get { return shoppingCartVisible; }
            set
            {
                shoppingCartVisible = value;
                OnPropertyChanged();
            }
        }

       
    }
}

