using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];
    public ProductsViewModel()
    {
        PageTitle = "Våra Produkter";
        LoadProducts();
    }
    // [RelayCommand]
    // public void Edit()
    // {
    //     System.Console.WriteLine("Ändra uppgifter");
    // }
    // [RelayCommand]
    // public void Delete()
    // {
    //     System.Console.WriteLine("Ta bort produkt");

    // }
    private void LoadProducts()
    {
        try
        {
            Products = new ObservableCollection<Product>(ProductServices.ListAllProducts());

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

    }
}
