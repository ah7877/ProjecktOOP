using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Exeptions;

namespace OOPEksamensOpgave.Models
{
    public class Product
    {
        private uint _id;
        private string _name;
        private decimal _price;
        private bool _isActive;
        private bool _canBeBoughtOnCredit;

        public Product(uint iD, string name, decimal price, bool active)
        {
            ID = iD;
            Name = name;
            Price = price;
            IsActive = active;
            CanBeBoughtOnCredit = false;
        }

        public string AllProductData()
        {
            return $"{ID,7} {Name,-40} {string.Format("{0:0.00}", Price),10} IsActive = {IsActive, 5} CanBeBoughtOnCredits = {CanBeBoughtOnCredit,5}";
        }

        public override string ToString()
        {
            return $"{ID,7} {Name,-40} {string.Format("{0:0.00}", Price),10}";
        }

        public void SwitchActiveStateOfProduct()
        {
            IsActive = !IsActive;
        }


        public uint ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                try
                {
                    if (value == null)
                    {
                        throw new NameNullExeption("Name of product can not be null");
                    }
                    else
                        _name = value;
                }
                catch (NameNullExeption e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public bool CanBeBoughtOnCredit
        {
            get { return _canBeBoughtOnCredit; }
            set { _canBeBoughtOnCredit = value; }
        }

    }
}
