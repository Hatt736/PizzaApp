using PizzaApp.Models;
using PizzaApp.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public ObservableCollection<PizzaMenuItem> MenuCollection{ get; set; }
        public ObservableCollection<Topping> Toppings { get; set; }
    }
}
