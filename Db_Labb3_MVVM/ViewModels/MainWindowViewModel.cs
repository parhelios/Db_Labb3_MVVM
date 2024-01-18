using CommunityToolkit.Mvvm.ComponentModel;
using Db_Labb3_MVVM.Managers.Interfaces;

namespace Db_Labb3_MVVM.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private readonly IDataManager _dataManager;

    public MainWindowViewModel(IDataManager dataManager)
    {
        _dataManager = dataManager;
    }
}