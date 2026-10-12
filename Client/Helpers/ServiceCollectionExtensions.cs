using System;
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
        collection.AddTransient<HomeViewModel>();
        collection.AddTransient<OrderViewModel>();
        collection.AddTransient<CustomerViewModel>();
        collection.AddTransient<ProductsViewModel>();
        collection.AddTransient<IProductService, ProductServices>();
        collection.AddTransient<ICustomerService, CustomerServices>();
        collection.AddTransient<IOrderService, OrderServices>();
    }
}
