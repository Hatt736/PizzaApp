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
       // builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();
        builder.Services.AddTransient<OrderPageViewModel>();
        builder.Services.AddTransient<CartPageViewModel>();
        builder.Services.AddTransient<CheckoutPageViewModel>();

        builder.Services.AddView<CartPage, CartPageViewModel>();
        builder.Services.AddView<CheckoutPage, CheckoutPageViewModel>();
        builder.Services.AddView<MainPage, MainPageViewModel>();
        builder.Services.AddView<OrderPage, OrderPageViewModel>();
        builder.Services.AddView<SettingsPage, SettingsPageViewModel>();
        return builder.Build();
    }

    private static void AddView<TView, TViewModel>(this IServiceCollection services)
 where TView : ContentPage
 where TViewModel : class
    {
        services.AddScoped<TView>(serviceProvider =>
        {
            var view = ActivatorUtilities.CreateInstance<TView>(serviceProvider);
            view.BindingContext = serviceProvider.GetRequiredService<TViewModel>();
            return view;
        });
    }
}
