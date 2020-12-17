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

namespace carRegistr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = logBox.Text.Trim();
            string password = PassBox.Text.Trim();

            if (login == "login" && password == "password")
            {
                Window1 wind1 = new Window1();
                wind1.Show();
                this.Close();
            }
            else 
            {
                logBox.ToolTip = "Login or password is wrong!";
                PassBox.ToolTip = "Login or password is wrong!";
            }


        }
    }
}
