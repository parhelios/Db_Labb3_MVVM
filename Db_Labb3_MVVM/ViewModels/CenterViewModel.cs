using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Db_Labb3_MVVM.Factories.Interfaces;
using Db_Labb3_MVVM.Managers.Interfaces;

namespace Db_Labb3_MVVM.ViewModels;

public class CenterViewModel : ObservableObject
{
    private readonly INavigationManager _navigationManager;

    public IRelayCommand NavigateLeftCommand { get; }

    public CenterViewModel(INavigationManager navigationManager, IViewModelFactory<LeftViewModel> leftFactory)
    {
        _navigationManager = navigationManager;

        NavigateLeftCommand = new RelayCommand(() =>
        {
            _navigationManager.CurrentViewModel = leftFactory.Create();
        });
    }
}