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
using System.Data.Sql;
using System.Data.SqlClient;


namespace Birger_Bolcher_GUI
{
    /// <summary>
    /// Interaction logic for BirgerBolcherHome.xaml
    /// </summary>
    public partial class BirgerBolcherHome : Page
    {
        public BirgerBolcherHome()
        {
            InitializeComponent();
        }

        private void BolcheDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowAllBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
