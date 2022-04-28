using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Repositories
{
    public interface IPizzaRepository
    {
        ObservableCollection<PizzaMenuItem> CreateMenuItemCollection();
        ObservableCollection<Topping> CreateToppingCollection();
    }

    public class PizzaRepository : IPizzaRepository
    {
        public ObservableCollection<Topping> CreateToppingCollection()
        {
            return new ObservableCollection<Topping>
            {
                new Topping { Name = "Pepperoni" },
                new Topping { Name = "Green Peppers" },
                new Topping { Name = "Sausage" },
                new Topping { Name = "Banana Peppers" },
                new Topping { Name = "Ham" },
                new Topping { Name = "Bacon" },
                new Topping { Name = "Onions" },
                new Topping { Name = "Cheese" }
            };
        }

        public ObservableCollection<PizzaMenuItem> CreateMenuItemCollection()
        {
            return new ObservableCollection<PizzaMenuItem>
            {
                new PizzaMenuItem {Name = "Pizza", Price = 14.95 },
                new PizzaMenuItem {Name = "Wings", Price = 10.99 },
                new PizzaMenuItem { Name = "Sides", Price = 4.99 },
                new PizzaMenuItem { Name = "Pasta", Price = 7.99 },
                new PizzaMenuItem { Name = "Desserts", Price = 6.99 },
                new PizzaMenuItem { Name = "Drinks", Price = 2.99 },
                new PizzaMenuItem { Name = "Dipping sauces", Price = .99 },
                new PizzaMenuItem { Name = "Deals", Price = 5.99 }
            };
        }
    }
}
