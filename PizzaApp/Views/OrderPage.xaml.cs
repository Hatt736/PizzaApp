using PizzaApp.Repositories;
using PizzaApp.ViewModels;

namespace PizzaApp.Views;


public partial class OrderPage : ContentPage
{
    private VisualElement lastElementSelected;

    public OrderPage()
    {
        InitializeComponent();
    }

    //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    //{
    //    if (lastElementSelected != null)
    //        VisualStateManager.GoToState(lastElementSelected, "Normal");

    //    VisualStateManager.GoToState((HorizontalStackLayout)sender, "Selected");

    //    lastElementSelected = (HorizontalStackLayout)sender;

    //}
}