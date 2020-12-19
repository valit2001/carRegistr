using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carRegistr
{
    [Table("owners")]
    public class Owner
    {   
        [Key]
        public int ownerID { get; set; } 

        private int pasport, tel;
        private string name, address, workPlace, birthdate;

        public int Pasport
        {
            get { return pasport; }
            set { pasport = value; }
        }

        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string WorkPlace
        {
            get { return workPlace; }
            set { workPlace = value; }
        }

        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public Owner() { }

        public Owner(int ownerID, string name, int pasport, int tel, string address, 
            string workPlace, string birthdate) 
        {
            this.ownerID = ownerID;
            this.address = address;
            this.birthdate = birthdate;
            this.name = name;
            this.pasport = pasport;
            this.tel = tel;
            this.workPlace = workPlace;
        }

    }
}
