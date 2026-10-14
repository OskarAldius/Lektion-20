using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class ProductsViewModel : PageViewModel
{
    private IProductService _service;
    [ObservableProperty]
    public partial ObservableCollection<Product> Products { get; set; } = [];
    public ProductsViewModel(IProductService service)
    {
        PageTitle = "Våra Produkter";
        PageName = Helpers.ApplicationNameEnum.Products;
        _service = service;
        LoadProducts();
    }
    [RelayCommand]
    public void Edit(string id)
    {
        System.Console.WriteLine("Ändra uppgifter, " + id);
    }
    [RelayCommand]
    public void Delete(string id)
    {
        System.Console.WriteLine("Ta bort produkt, " + id);

    }
    private void LoadProducts()
    {
        try
        {


            Products = new ObservableCollection<Product>(_service.List());

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

    }
}
