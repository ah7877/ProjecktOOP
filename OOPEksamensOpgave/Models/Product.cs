using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _price;
        private bool _active;
        private bool _canBeBoughtOnCredit;

        public Product(int iD, string name, decimal price, bool active)
        {
            ID = iD;
            Name = name;
            Price = price;
            Active = active;
        }

        public override string ToString()
        {
            return $"{ID, -5} {Name, -40} {string.Format("{0:0.00}",Price), 10}";
        }



        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = value; 
            }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public bool CanBeBoughtOnCredit
        {
            get { return _canBeBoughtOnCredit; }
            set { _canBeBoughtOnCredit = value; }
        }

    }
}
