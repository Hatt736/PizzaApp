using Microsoft.Maui.ApplicationModel;

namespace PizzaApp;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent();
    }


    void OnDarkModeToggled(object sender, ToggledEventArgs e)
    {
        // Perform an action after examining e.Value
        if (e.Value)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
    }
}