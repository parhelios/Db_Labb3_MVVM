using CommunityToolkit.Mvvm.ComponentModel;
using Db_Labb3_MVVM.Factories;
using Db_Labb3_MVVM.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Db_Labb3_MVVM.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddViewModelFactory<TViewModel>(this IServiceCollection services) 
        where TViewModel : ObservableObject
    {
        services.AddTransient<TViewModel>();
        services.AddTransient<Func<TViewModel>>(
            sp => () => 
                sp.GetService<TViewModel>()!);
        services.AddSingleton<IViewModelFactory<TViewModel>, 
            ViewModelFactory<TViewModel>>();
    }
}