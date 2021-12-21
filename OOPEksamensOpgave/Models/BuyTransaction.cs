using OOPEksamensOpgave.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Services;
using OOPEksamensOpgave.Interfaces;

namespace OOPEksamensOpgave.Models
{
    public class BuyTransaction : Transaction
    {
        private Product _product;

        public BuyTransaction(Product product, User user) : base(user, -product.Price)
        {
            Product = new Product(product.ID, product.Name, product.Price, product.IsActive);
        }

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public override void Execute()
        {
            if (User.Balance + Amount > 0 || Product.CanBeBoughtOnCredit == true)
            {
                User.Balance += Amount;
                LogTransactions.LogATransaction(this);
            }
            else
                throw new InsufficientCreditsException( User, Product);
        }

        public override string ToString()
        {
            return $"{ID,7} {User.UserName,-10} {Product.Name,-20} {string.Format("{0:0.00}", Amount * -1),10}, {Date.ToShortDateString(),-10} purchase transaction";
        }
    }
}
