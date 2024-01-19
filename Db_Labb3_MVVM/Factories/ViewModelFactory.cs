using Db_Labb3_MVVM.Factories.Interfaces;

namespace Db_Labb3_MVVM.Factories;

public class ViewModelFactory<TViewModel> : IViewModelFactory<TViewModel> where TViewModel : class
{
    private readonly Func<TViewModel> _factory;

    public ViewModelFactory(Func<TViewModel> factory)
    {
        _factory = factory;
    }
    public TViewModel Create()
    {
        return _factory();
    }
}