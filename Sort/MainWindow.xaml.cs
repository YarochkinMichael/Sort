using Sort.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICore core;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(ICore core)
        {
            InitializeComponent();

            this.core = core;
        }

        public void SetCore(ICore core)
        {
            this.core = core;
        }

        private void FillDatabase_Click(object sender, RoutedEventArgs e)
        {
            core.FillInitialTable();
        }

        private void SortNumbers_Click(object sender, RoutedEventArgs e)
        {
            core.SortValues();
        }
    }
}
