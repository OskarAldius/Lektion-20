using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HomeViewModel _homeView = new();
    private readonly ProductsViewModel _productsView = new();
    private readonly CustomerViewModel _customerView = new();
    private readonly OrderViewModel _orderView = new();
    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    public MainWindowViewModel()
    {
        CurrentView = _homeView;
    }

    [RelayCommand]
    private void GoToHome() => CurrentView = _homeView;
    [RelayCommand]

    private void GoToProducts() => CurrentView = _productsView;
    [RelayCommand]

    private void GoToCustomer() => CurrentView = _customerView;
    [RelayCommand]

    private void GoToOrder() => CurrentView = _orderView;
}
