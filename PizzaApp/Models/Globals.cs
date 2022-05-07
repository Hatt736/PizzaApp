using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public static class Globals
    {
        public static List<CartItem> CartItems { get; set; }
        public static double Subtotal { get; set; }
        //public static double Total { get; set; }
        //public static double SalesTax { get; set; }
        public static double SalesTaxRate { get; set; } = .06;
    }
}
