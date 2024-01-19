namespace Db_Labb3_MVVM.Factories.Interfaces;

public interface IViewModelFactory<out TViewModel> 
{
    TViewModel Create();
}