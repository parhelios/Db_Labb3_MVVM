using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace Db_Labb3_MVVM.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddViewModelFactory<TViewModel>(this IServiceCollection services) 
        where TViewModel : ObservableObject
    {

    }
}