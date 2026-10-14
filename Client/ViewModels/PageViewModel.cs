using System;
using Client.Helpers;
using Client.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class PageViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial ApplicationNameEnum PageName { get; set; }
}
