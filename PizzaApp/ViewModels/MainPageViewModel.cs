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
           WelcomeMessage = "Hatt's Pizza!";
        }


        private string _welcomeMessage = "Default Message";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { _welcomeMessage = value; }
        }

        private ICommand myVar;
        public ICommand NavigateToOrderPageCommand =>
            myVar ??
            (myVar = new Command<object>(async (x) => await ExecuteMyCommand(x)));

        private async Task ExecuteMyCommand(object parameter)
        {
            if ((string)parameter == "Delivery")
            {
                //Get users name and address
                await Shell.Current.GoToAsync(nameof(OrderPage));

            }
            else
            {
                await Shell.Current.GoToAsync(nameof(OrderPage));
            }

            
        }

        private ICommand navigateToSettingsCommand;
        public ICommand NavigateToSettingsCommand =>
        navigateToSettingsCommand ??
        (navigateToSettingsCommand = new Command<object>(async (x) => await ExecuteNavigateToSettingsCommand(x)));

        private async Task ExecuteNavigateToSettingsCommand(object obj)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage));
        }

        private ICommand navigateToSignInCommand;
        public ICommand NavigateToSignInCommand =>
        navigateToSignInCommand ??
        (navigateToSignInCommand = new Command<object>(async (x) => await ExecuteNavigateToSignInCommand(x)));

        private async Task ExecuteNavigateToSignInCommand(object obj)
        {
            await Shell.Current.GoToAsync(nameof(SignInPage));
        }
    }
}
