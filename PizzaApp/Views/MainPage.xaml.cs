namespace PizzaApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnOrderClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new OrderPage());
	}
}

