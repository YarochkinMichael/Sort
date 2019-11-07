using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using Sort.Controller;
using Sort.Service;
using Sort.Repository;

namespace Sort
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ITable originalTable = new SQLTable("original");
            ITable sortedTable = new SQLTable("sorted");
            INumbers originalNnumbers = new Numbers(originalTable);
            INumbers sortedNnumbers = new Numbers(sortedTable);
            ISorting sorting = new CountingSorting();
            ICore core = new Core(sorting, originalNnumbers, sortedNnumbers);
            MainWindow window = new MainWindow(core);

            window.Show();
        }
    }
}
