using OOPEksamensOpgave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Exeptions
{
    class InsufficientCreditsException : Exception
    {
        private User _user;
        private Product _product;
        
        public InsufficientCreditsException(string message, User user, Product product) : base(message)
        {
            User = user;
            Product = product;
        }

        public override string ToString()
        {
            return $"{Message}\nUser = {User.AllUserData()} \nProduct = {Product.AllProductData()}";
        }

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }


        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }


    }
}
