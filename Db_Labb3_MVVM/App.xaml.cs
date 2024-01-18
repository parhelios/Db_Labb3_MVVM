using System.Configuration;
using System.Data;
using System.Windows;
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
                
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {   
            AppHost.StartAsync();

            //Sätta upp MainWindow

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost.StopAsync();

            base.OnExit(e);
        }
    }

}
