using CommunityToolkit.Mvvm.ComponentModel;
using Db_Labb3_MVVM.Managers.Interfaces;
using Db_Labb3_MVVM.Models;
using ZstdSharp.Unsafe;

namespace Db_Labb3_MVVM.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private readonly IDataManager _dataManager;

    private readonly DataModel _dataModel;

    private int _counter;

    public int Counter
    {
        get => _counter;
        set => SetProperty(ref _counter, value);
    }

    public MainWindowViewModel(IDataManager dataManager)
    {
        _dataManager = dataManager;
        _dataModel = _dataManager.DataModel; 
    }
}