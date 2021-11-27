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
        private int _price;
        private bool _active;
        private bool _canBeBoughtOnCredit;


        /*
            implimentationer
                ToString
                    ID, Navn og Pris
                fornuftig constructer
         */







        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
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
