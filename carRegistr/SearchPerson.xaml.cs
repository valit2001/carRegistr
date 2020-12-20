using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace carRegistr
{
    /// <summary>
    /// Interaction logic for SearchPerson.xaml
    /// </summary>
    public partial class SearchPerson : Window
    {
        AppContext db;

        public SearchPerson()
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
            string owName = searchOwnerName.Text;

            Owner ow = null;

            using (AppContext DB = new AppContext())
            {
                ow = db.Owners.Where(b => b.Name == owName).FirstOrDefault();
            }

            if(ow != null)
            {
                MessageBox.Show(" Name: " + ow.Name + "\n ID:" + ow.ownerID + "\n Passport: "
                    + ow.Pasport + "\n Address: " + ow.Address + "\n Birthdate :" + ow.Birthdate
                    + "\n Tel: " + ow.Tel + "\n Work: " + ow.WorkPlace) ;
            }
            else
            {
                MessageBox.Show("---");
            }

        }
    }
}
