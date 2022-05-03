using PizzaApp.Repositories;
using PizzaApp.Views;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PizzaApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
       // INavigation _navigation;

        public MainPageViewModel()
        {
         
        }

        private ICommand myVar;
        public ICommand NavigateToOrderPageCommand =>
            myVar ??
            (myVar = new Command<object>(async (x) => await ExecuteMyCommand(x)));

        private async Task ExecuteMyCommand(object x)
        {
            await Shell.Current.GoToAsync(nameof(OrderPage));
        }
    }
}
