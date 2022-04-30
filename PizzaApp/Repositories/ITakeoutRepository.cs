using PizzaApp.Models;

using System.Collections.ObjectModel;

namespace PizzaApp.Repositories
{
    public interface ITakeoutRepository
    {
        ObservableCollection<TakeoutItemCategoryGroup> CreateGroupedMenuItemsCollection();
        ObservableCollection<Topping> CreateToppingCollection();
    }
}