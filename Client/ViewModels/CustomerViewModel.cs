using System;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomerViewModel : ViewModelBase
{
    private ICustomerService _service;
    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];

    public CustomerViewModel() { }
    public CustomerViewModel(ICustomerService customerService)
    {
        PageTitle = "Våra Kunder";
        _service = customerService;
        RegestingCustomers();
    }

    private void RegestingCustomers()
    {
        try
        {

            Customers = new ObservableCollection<Customer>(_service.List());

        }
        catch (Exception ex)
        {

            System.Console.WriteLine(ex.Message);
        }
    }
}
