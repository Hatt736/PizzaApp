using PizzaApp.Models;
using PizzaApp.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.ViewModels
{
    public class CheckoutPageViewModel : BaseViewModel
    {
        ITakeoutRepository _takeoutRepository;

        public CheckoutPageViewModel(ITakeoutRepository takeoutRepository)
        {
            _takeoutRepository = takeoutRepository;

            Subtotal = _takeoutRepository.CurrentOrder.Subtotal;
            SalesTax = Subtotal * Constants.SalesTaxRate;
            Total =  Subtotal + SalesTax;
        }

        private double subtotal;
        public double Subtotal
        {
            get { return subtotal; }
            set
            {
                subtotal = value;
                OnPropertyChanged();
            }
        }

        private double salestax;
        public double SalesTax
        {
            get { return salestax; }
            set
            {
                salestax = value;
                OnPropertyChanged();
            }
        }

        private double total;
        public double Total
        {
            get { return total; }
            set
            {
                total = value;
                OnPropertyChanged();
            }
        }
    }
}
