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
using System.Windows.Shapes;

namespace carRegistr
{
    /// <summary>
    /// Interaction logic for SearchCar.xaml
    /// </summary>
    public partial class SearchCar : Window
    {
        AppContext db;

        public SearchCar()
        {
            InitializeComponent();

            db = new AppContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wind = new Window1();
            wind.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
