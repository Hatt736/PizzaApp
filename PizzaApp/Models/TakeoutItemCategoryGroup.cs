namespace PizzaApp.Models
{
    public class TakeoutItemCategoryGroup : List<TakeoutMenuItem>
    {
        public string CategoryName { get; private set; }

        public TakeoutItemCategoryGroup(string categoryName, List<TakeoutMenuItem> takeoutItems) : base(takeoutItems)
        {
            CategoryName = categoryName;
        }
    }
}

