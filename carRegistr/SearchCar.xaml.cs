using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

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
            string searchVal = searchValue.Text;

            Car car = null;

            using (AppContext db = new AppContext())
            {
                car = db.Cars.Where(a => a.Number.ToString() == searchVal || 
                a.Brand == searchVal || a.Code == searchVal).FirstOrDefault();
            }

            if (car != null)
            {
                Owner ow1 = null;

                using (AppContext db = new AppContext())
                {
                    ow1 = db.Owners.Where(a => a.ownerID == car.OwnerID).FirstOrDefault();
                }

                MessageBox.Show($"Car full number: {car.Code} {car.Number} {car.Seria}\n" +
                    $"Car brand, model and color: {car.Brand} {car.Model} {car.Color}\n" +
                    $"Car owner ID, Name and Tel: {car.OwnerID} {ow1.Name} {ow1.Tel}");
            }
            else
            {
                MessageBox.Show("---");
            }
        }
    }
}



//List<Car> cars = db.Cars.ToList();
            //string str = "";
            //foreach (Car car in cars)
            //{
            //    str += car.Color + " | "; 
            //}
            //MessageBox.Show(str);