using System;
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class CustomerViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ObservableCollection<Customer> Customers { get; set; } = [];
    public CustomerViewModel()
    {
        PageTitle = "Våra Kunder";
        RegestingCustomers();
    }

    private void RegestingCustomers()
    {
        try
        {

            Customers = new ObservableCollection<Customer>(CustomerServices.ListAllCustomers());

        }
        catch (Exception ex)
        {

            System.Console.WriteLine(ex.Message);
        }
    }
}
