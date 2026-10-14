using System;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class CustomerViewModel : PageViewModel
{
    private ICustomerService _service;
    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];
    public CustomerViewModel() { }

    public CustomerViewModel(ICustomerService customerService)
    {
        PageTitle = "Våra Kunder";
        PageName = Helpers.ApplicationNameEnum.Customers;
        _service = customerService;
        RegestingCustomers();
    }
    [RelayCommand]
    public void Edit(string id)
    {
        System.Console.WriteLine("Ändra uppgifter, " + id);
    }
    [RelayCommand]
    public void Delete(string id)
    {
        System.Console.WriteLine("Ta bort kund, " + id);

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
