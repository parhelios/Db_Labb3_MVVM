using CommunityToolkit.Mvvm.ComponentModel;
using Db_Labb3_MVVM.Managers.Interfaces;

namespace Db_Labb3_MVVM.Services;

public class NavigationManager : INavigationManager
{
    private ObservableObject _currentViewModel;

    public ObservableObject CurrentViewModel
    {
        get
        {
            return _currentViewModel;
        }
        set
        {
            _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }

    public event Action? CurrentViewModelChanged;

    public void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}