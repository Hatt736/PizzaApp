using PizzaApp.Models;
using PizzaApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuItem = PizzaApp.Models.MenuItem;

namespace PizzaApp.ViewModels
{
    public class OrderPageViewModel : BaseViewModel
    {
        IPizzaRepository _pizzaRepository;

        public OrderPageViewModel()
        {
            _pizzaRepository = new PizzaRepository();

            MenuList = new ObservableCollection<MenuItem>(_pizzaRepository.CreateMenuItemCollection());

            Toppings = new ObservableCollection<Topping>(_pizzaRepository.CreateToppingCollection());
        }

        public ObservableCollection<MenuItem> MenuList { get; set; }
        public ObservableCollection<Topping> Toppings { get; set; }
    }
}
