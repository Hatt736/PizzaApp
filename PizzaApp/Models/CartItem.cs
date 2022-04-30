using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class CartItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quanity { get; set; }

        public CartItem()
        {

        }

        public CartItem(string name, double price, int quanity)
        {
            Name = name;
            Price = price;
            Quanity = quanity;
        }
    }
}
