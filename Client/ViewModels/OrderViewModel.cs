using System;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class OrderViewModel : PageViewModel
{
    private IOrderService _service;
    [ObservableProperty]
    public partial ObservableCollection<Order> Orders { get; set; } = [];

    public OrderViewModel() { }
    public OrderViewModel(IOrderService orderService)
    {
        PageTitle = "Våra Beställningar";
        PageName = Helpers.ApplicationNameEnum.Orders;
        _service = orderService;
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
        System.Console.WriteLine("Ta bort beställning, " + id);

    }
    private void LoadProducts()
    {
        try
        {
            Orders = new ObservableCollection<Order>(_service.List());

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

    }
}
