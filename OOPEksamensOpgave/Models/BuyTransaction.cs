using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    public class BuyTransaction : Transaction
    {
        private Product _product;

        public BuyTransaction(Product product, int iD, User user, int amount) : base(iD, user, amount)
        {
            Product = product;
        }

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
