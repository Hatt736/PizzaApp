using PizzaApp.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Repositories
{
    public interface ITakeoutRepository
    {
        ObservableCollection<TakeoutItemCategoryGroup> CreateGroupedMenuItemsCollection();
        ObservableCollection<Topping> CreateToppingCollection();
    }

    public partial class TakeoutRepository : ITakeoutRepository
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

        private List<TakeoutMenuItem> CreateTakeoutMenuItemList()
        {
            return new List<TakeoutMenuItem>
            {
                new TakeoutMenuItem {Name = "Cheese Pizza", Category = "Pizza", Price = 14.95 },
                new TakeoutMenuItem {Name = "Pepperoni Pizza", Category = "Pizza", Price = 14.95 },
                new TakeoutMenuItem {Name = "Barbeque Pizza", Category = "Pizza", Price = 14.95 },
                new TakeoutMenuItem {Name = "Hawaiian Pizza", Category = "Pizza", Price = 14.95 },
                new TakeoutMenuItem {Name = "Steak Pizza", Category = "Pizza", Price = 14.95 },
                new TakeoutMenuItem {Name = "Chicken Pizza", Category = "Pizza", Price = 14.95 },
                new TakeoutMenuItem {Name = "Supreme Pizza", Category = "Pizza", Price = 14.95 },
                new TakeoutMenuItem {Name = "Vegan Pizza", Category = "Pizza", Price = 14.95 },
                new TakeoutMenuItem {Name = "Pizza Sub", Category = "Subs", Price = 14.95 },
                new TakeoutMenuItem {Name = "Meatball Sub", Category = "Subs", Price = 14.95 },
                new TakeoutMenuItem {Name = "Barbeque Chicken Sub", Category = "Subs", Price = 14.95 },
                new TakeoutMenuItem {Name = "Deli Sub", Category = "Subs", Price = 14.95 },
                new TakeoutMenuItem {Name = "Cheese Steak Sub", Category = "Subs", Price = 14.95 },
                new TakeoutMenuItem {Name = "Chicken Parm Sub", Category = "Subs", Price = 14.95 },
                new TakeoutMenuItem {Name = "Ham & Cheese Sub", Category = "Subs", Price = 14.95 },
                new TakeoutMenuItem {Name = "Vegan Sub", Category = "Subs", Price = 14.95 },
                new TakeoutMenuItem {Name = "Wings", Category = "Sides", Price = 10.99 },
                new TakeoutMenuItem { Name = "Sides", Category = "Sides", Price = 4.99 },
                new TakeoutMenuItem { Name = "Pasta", Category = "Sides", Price = 7.99 },
                new TakeoutMenuItem { Name = "Brownie", Category = "Desserts", Price = 3.99 },
                new TakeoutMenuItem { Name = "Cookie", Category = "Desserts", Price = 1.99 },
                new TakeoutMenuItem { Name = "Apple Pie", Category = "Desserts", Price = 5.99 },
                new TakeoutMenuItem { Name = "Coke", Category = "Drinks", Price = 2.99 },
                new TakeoutMenuItem { Name = "Spite", Category = "Drinks", Price = 2.99 },
                new TakeoutMenuItem { Name = "Dr. Pepper", Category = "Drinks", Price = 2.99 },
                new TakeoutMenuItem { Name = "Mt. Dew", Category = "Drinks", Price = 2.99 },
                new TakeoutMenuItem { Name = "Dipping Sauces", Category = "Add Ons", Price = .99 }
            };
        }

        public ObservableCollection<TakeoutItemCategoryGroup> CreateGroupedMenuItemsCollection()
        {
            List<TakeoutMenuItem> rawList = CreateTakeoutMenuItemList();

            List<TakeoutItemCategoryGroup> groupedList = new List<TakeoutItemCategoryGroup>();

            groupedList.Add(new TakeoutItemCategoryGroup("Pizza", new List<TakeoutMenuItem>
            (rawList.Where(c => c.Category == "Pizza").ToList())));

            groupedList.Add(new TakeoutItemCategoryGroup("Subs", new List<TakeoutMenuItem>
                      (rawList.Where(c => c.Category == "Subs").ToList())));

            groupedList.Add(new TakeoutItemCategoryGroup("Sides", new List<TakeoutMenuItem>
                      (rawList.Where(c => c.Category == "Sides").ToList())));

            groupedList.Add(new TakeoutItemCategoryGroup("Desserts", new List<TakeoutMenuItem>
          (rawList.Where(c => c.Category == "Desserts").ToList())));

            groupedList.Add(new TakeoutItemCategoryGroup("Drinks", new List<TakeoutMenuItem>
          (rawList.Where(c => c.Category == "Drinks").ToList())));


            return new ObservableCollection<TakeoutItemCategoryGroup>(groupedList);
        }
    }
}
