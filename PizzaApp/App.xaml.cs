using Microsoft.Maui.ApplicationModel;

using PizzaApp.Views;


namespace PizzaApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

      //  App.Current.UserAppTheme = AppTheme.Unspecified;
        Application.Current.RequestedThemeChanged += (s, a) =>
        {
            if (a.RequestedTheme == AppTheme.Light)
            {
                App.Current.UserAppTheme = AppTheme.Light;
            }
            else
            {
                App.Current.UserAppTheme = AppTheme.Dark;
            }


            // Respond to the theme change


        };
    }
}
