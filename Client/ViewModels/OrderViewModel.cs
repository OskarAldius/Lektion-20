using System;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class OrderViewModel : ViewModelBase
{
    private IOrderService _service;
    [ObservableProperty]
    public partial ObservableCollection<Order> Orders { get; set; } = [];

    public OrderViewModel() { }
    public OrderViewModel(IOrderService orderService)
    {
        PageTitle = "Våra Beställningar";
        _service = orderService;
        LoadProducts();
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
