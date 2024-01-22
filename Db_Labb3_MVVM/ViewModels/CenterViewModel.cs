using CommunityToolkit.Mvvm.ComponentModel;
using Db_Labb3_MVVM.Factories.Interfaces;
using Db_Labb3_MVVM.Managers.Interfaces;

namespace Db_Labb3_MVVM.ViewModels;

public class CenterViewModel : ObservableObject
{
    private readonly INavigationManager _navigationManager;

    public CenterViewModel(INavigationManager navigationManager, IViewModelFactory<LeftViewModel> leftFactory)
    {
        _navigationManager = navigationManager;


    }
}