using System.Windows;
using Db_Labb3_MVVM.Extensions;
using Db_Labb3_MVVM.Managers.Interfaces;
using Db_Labb3_MVVM.Services;
using Db_Labb3_MVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Db_Labb3_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }

        public App()
        {
            //Sätta upp alla beroenden och instansieringar
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddScoped<IDataManager, DataManager>();
                    services.AddScoped<INavigationManager, NavigationManager>();

                    services.AddViewModelFactory<MainWindowViewModel>();
                    services.AddViewModelFactory<LeftViewModel>();
                    services.AddViewModelFactory<CenterViewModel>();
                    //services.AddViewModelFactory<RightViewModel>();

                    services.AddSingleton<MainWindow>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {   
            await AppHost.StartAsync(); 

            var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
            mainWindow.DataContext = AppHost.Services.GetRequiredService<MainWindowViewModel>();

            mainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();

            base.OnExit(e);
        }
    }

}
