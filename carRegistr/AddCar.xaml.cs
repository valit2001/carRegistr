using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace carRegistr
{
    /// <summary>
    /// Interaction logic for AddCar.xaml
    /// </summary>
    public partial class AddCar : Window
    {
        AppContext db;

        public AddCar()
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
            int ownerID = int.Parse(ownerid.Text);
            string name = ownerName.Text;
            int pasport = int.Parse(ownerPasport.Text);
            int tel = int.Parse(ownerTel.Text);
            string address = ownerAddress.Text;
            string workPlace = ownerWork.Text; 
            string birthdate = ownerBirthdate.Text;

            int number = int.Parse(carNum.Text);
            string code = carCode.Text;
            string seria = carSeria.Text;
            string brand = carBrand.Text;
            string model = carModel.Text;
            string color = carColor.Text;

            Owner owner = new Owner(ownerID, name, pasport, tel, address, workPlace, birthdate);
            db.Owners.Add(owner);
            db.SaveChanges();

            Car car = new Car(number, ownerID, code, seria, brand, model, color);

            try
            {
                db.Cars.Add(car);
                db.SaveChanges();

                MessageBox.Show("Car added.");
            }
            catch
            {
                MessageBox.Show("Smth is wrong.");
            }

        }

        private void ownerPasport_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
