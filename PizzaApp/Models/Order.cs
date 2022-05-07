using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class Order
    {

        //what does an order class need

        public string OrderNumber { get; set; }
        public Customer TakeOutCustomer { get; set; }
        public List<CartItem> TakeOutOrderList { get; set; } 
        public double SubTotal { get; set; }

        public Order()
        {
            TakeOutCustomer = new Customer(); 

            TakeOutOrderList = new List<CartItem>();
        }
    }
}
