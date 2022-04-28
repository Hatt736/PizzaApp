using PizzaApp.Models;
using PizzaApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuItem = PizzaApp.Models.MenuItem;

namespace PizzaApp.ViewModels
{
    public class OrderPageViewModel
    {
        IPizzaRepository _pizzaRepository;
        public OrderPageViewModel(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;

            MenuList = _pizzaRepository.CreateMenuItemList();

            Toppings = _pizzaRepository.CreateToppingList();
        }

        public List<MenuItem> MenuList { get; set; }
        public List<Topping> Toppings { get; set; }
    }
}
