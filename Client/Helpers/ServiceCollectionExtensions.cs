using System;
using Avalonia.Controls;
using Client.Factories;
using Client.Interfaces;
using Client.Services;
using Client.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Client.Helpers;

public static class ServiceCollectionExtensions
{
    public static void AddServices(this IServiceCollection collection)
    {
        //collection.AddSingletion<MainViewModel>();
        //collection.AddTransient<IProductServices,ProductServices>();
        collection.AddSingleton<MainWindowViewModel>();
        collection.AddSingleton<PageViewFactory>();
        collection.AddTransient<HomeViewModel>();
        collection.AddTransient<OrderViewModel>();
        collection.AddTransient<CustomerViewModel>();
        collection.AddTransient<ProductsViewModel>();
        collection.AddTransient<IProductService, ProductServices>();
        collection.AddTransient<ICustomerService, CustomerServices>();
        collection.AddTransient<IOrderService, OrderServices>();

        collection.AddSingleton<Func<ApplicationNameEnum, PageViewModel>>(c => name => name switch
        {
            ApplicationNameEnum.Home => c.GetRequiredService<HomeViewModel>(),
            ApplicationNameEnum.Customers => c.GetRequiredService<CustomerViewModel>(),
            ApplicationNameEnum.Orders => c.GetRequiredService<OrderViewModel>(),
            ApplicationNameEnum.Products => c.GetRequiredService<ProductsViewModel>(),
            _ => throw new InvalidOperationException("Det gick åt h-e")
        });
    }
}
