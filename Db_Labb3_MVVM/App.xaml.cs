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


    }

}
