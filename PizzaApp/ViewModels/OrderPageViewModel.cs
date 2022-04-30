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
    public class OrderPageViewModel : BaseViewModel
    {
        IPizzaRepository _pizzaRepository;

        public OrderPageViewModel(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;

            MenuCollection = new ObservableCollection<PizzaMenuItem>(_pizzaRepository.CreateMenuItemCollection());

            Toppings = new ObservableCollection<Topping>(_pizzaRepository.CreateToppingCollection());

            CartItems = new ObservableCollection<CartItem>();
        }

        public ObservableCollection<PizzaMenuItem> MenuCollection { get; set; }
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
            set { subtotal = value; 
                OnPropertyChanged(); }
        }


        private object selectedItem;
        public object SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value;
                OnPropertyChanged(); }
        }


        private ICommand selectItemCommand;
        public ICommand SelectItemCommand =>
        selectItemCommand ??
        (selectItemCommand = new Command<object>((x) => ExecuteSelectItemCommand(x)));

        private void ExecuteSelectItemCommand(object selection)
        {
            if (selection == null)
                return;

            var selectedItem = selection as PizzaMenuItem;

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
                    item.Quanity++ ;
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

