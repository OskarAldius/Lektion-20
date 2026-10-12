using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly HomeViewModel _homeView;
    private readonly ProductsViewModel _productsView;
    private readonly CustomerViewModel _customerView;
    private readonly OrderViewModel _orderView;
    [ObservableProperty]
    public partial ViewModelBase CurrentView { get; set; }

    //Design...
    public MainWindowViewModel() { }

    public MainWindowViewModel(
        ProductsViewModel productsViewModel,
        HomeViewModel homeViewModel,
        CustomerViewModel customerViewModel,
        OrderViewModel orderViewModel

        )
    {
        _productsView = productsViewModel;
        _homeView = homeViewModel;
        _customerView = customerViewModel;
        _orderView = orderViewModel;

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
