using PizzaApp.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Repositories
{
    public interface IOrderRepository
    {
        Order CurrentOrder { get; set; }
    }

    public partial class OrderRepository : IOrderRepository
    {
        public Order CurrentOrder { get; set; }

        public OrderRepository()
        {
            CurrentOrder = new Order();
        }

    }
}
