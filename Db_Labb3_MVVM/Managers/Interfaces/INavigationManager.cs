using CommunityToolkit.Mvvm.ComponentModel;

namespace Db_Labb3_MVVM.Managers.Interfaces;

public interface INavigationManager
{
    ObservableObject CurrentViewModel { get; set; }

    event Action? CurrentViewModelChanged;

    void OnCurrentViewModelChanged();
}