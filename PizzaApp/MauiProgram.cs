using PizzaApp.Repositories;
using PizzaApp.ViewModels;

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
			});

		builder.Services.AddSingleton<IPizzaRepository, PizzaRepository>();
		builder.Services.AddTransient<OrderPage>();
		builder.Services.AddTransient<OrderPageViewModel>();
		return builder.Build();
	}
}
