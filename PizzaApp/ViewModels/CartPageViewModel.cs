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
    public class CartPageViewModel : BaseViewModel
    {
        IPizzaRepository _pizzaRepository;


        public CartPageViewModel(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;

            CartCollection = new ObservableCollection<PizzaMenuItem>(_pizzaRepository.CreateMenuItemCollection());


        }

        public ObservableCollection<PizzaMenuItem> CartCollection { get; set; }

    }
}
