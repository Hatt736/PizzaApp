using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuItem = PizzaApp.Models.MenuItem;

namespace PizzaApp.Repositories
{
    public interface IPizzaRepository
    {
        ObservableCollection<MenuItem> CreateMenuItemCollection();
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

        public ObservableCollection<MenuItem> CreateMenuItemCollection()
        {
            return new ObservableCollection<MenuItem>
            {
                new MenuItem {Name = "Pizza", Price = 14.95 },
                new MenuItem {Name = "Wings", Price = 10.99 },
                new MenuItem { Name = "Sides", Price = 4.99 },
                new MenuItem { Name = "Pasta", Price = 7.99 },
                new MenuItem { Name = "Desserts", Price = 6.99 },
                new MenuItem { Name = "Drinks", Price = 2.99 },
                new MenuItem { Name = "Dipping sauces", Price = .99 },
                new MenuItem { Name = "Deals", Price = 5.99 }
            };
        }
    }
}
