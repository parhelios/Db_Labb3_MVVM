namespace Db_Labb3_MVVM.Factories.Interfaces;

public interface IViewModelFactory<out TViewModel> where TViewModel : class
{
    TViewModel Create();
}