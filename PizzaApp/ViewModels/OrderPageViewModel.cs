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

            CartItems = new ObservableCollection<PizzaMenuItem>();
        }

        public ObservableCollection<PizzaMenuItem> MenuCollection { get; set; }
        public ObservableCollection<Topping> Toppings { get; set; }

        public ObservableCollection<PizzaMenuItem> CartItems { get; set; }

        private object selectedItem;

        public object SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; }
        }


        private ICommand selectItemCommand;
        public ICommand SelectItemCommand =>
        selectItemCommand ??
        (selectItemCommand = new Command<object>(async (x) => await ExecuteSelectItemCommand(x)));



        private async Task ExecuteSelectItemCommand(object selection)
        {
            if (selection == null)
                return;

            selection = null;

            var selectedItem = selection as PizzaMenuItem;

            CartItems.Add(selectedItem);

            selectedItem = null;
        }
    }
}
