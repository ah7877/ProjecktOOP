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
        
        public InsufficientCreditsException(User user, Product product)
        {
            User = user;
            Product = product;
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
