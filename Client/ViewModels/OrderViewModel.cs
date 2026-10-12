using System;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class OrderViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Order> Orders { get; set; } = [];
    public OrderViewModel()
    {
        PageTitle = "Våra Beställningar";
        LoadProducts();
    }
    private void LoadProducts()
    {
        try
        {
            Orders = new ObservableCollection<Order>(OrderServices.ListAllProducts());

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

    }
}
