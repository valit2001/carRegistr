using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace carRegistr
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        public int carID { get; set; }

        private int number;

        private int ownerID;

        private string code, seria, brand, model, color;

        public int Number {
            get { return number; }
            set { number = value; }
        }

        public int OwnerID
        {
            get { return ownerID; }
            set { ownerID = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Seria
        {
            get { return seria; }
            set { seria = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car() { }

        public Car(int number, int ownerID, string code, string seria, 
            string brand, string model, string color) 
        {
            this.brand = brand;
            this.code = code;
            this.color = color;
            this.model = model;
            this.number = number;
            this.ownerID = ownerID;
            this.seria = seria;
        }

    }
}
