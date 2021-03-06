using PizzaApp.Repositories;
using PizzaApp.ViewModels;
using PizzaApp.Views;

namespace PizzaApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Font Awesome 6 Brands-Regular-400", "FAB-400");
				fonts.AddFont("Font Awesome 6 Free-Regular-400", "FAS-400");
				fonts.AddFont("Font Awesome 6 Free-Solid-900", "FAS-900");
			});

		builder.Services.AddSingleton<ITakeoutRepository, TakeoutRepository>();
		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();
		builder.Services.AddTransient<OrderPage>();
		builder.Services.AddTransient<OrderPageViewModel>();
		builder.Services.AddTransient<CartPage>();
		builder.Services.AddTransient<CartPageViewModel>();
		builder.Services.AddTransient<CheckoutPage>();
		builder.Services.AddTransient<CheckoutPageViewModel>();
		return builder.Build();
	}
}
