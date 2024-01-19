using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Db_Labb3_MVVM.Managers.Interfaces;
using Db_Labb3_MVVM.Models;
using ZstdSharp.Unsafe;

namespace Db_Labb3_MVVM.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private readonly IDataManager _dataManager;

    private readonly DataModel _dataModel;

    public int Counter
    {
        get => _dataModel.Counter;
        set => SetProperty(
            _dataModel.Counter, 
            value, 
            _dataModel, 
            (model, value) => model.Counter = value);
    }

    public MainWindowViewModel(IDataManager dataManager)
    {
        _dataManager = dataManager;
        _dataModel = _dataManager.DataModel; 
    }
}