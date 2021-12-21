using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Exeptions
{
    class ProductNotFoundException : Exception
    {
        private string _productID;

        public string ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public ProductNotFoundException(string productID)
        {
            ProductID = productID;
        }
    }
}
