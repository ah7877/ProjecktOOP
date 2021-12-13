using OOPEksamensOpgave.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Services;

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
            try
            {
                if (User.Balance + Amount > 0)
                {
                    User.Balance += Amount;

                }
                else
                    throw new InsufficientCreditsException("User Balance is too low for this transaction", User, Product);
            }
            catch(InsufficientCreditsException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public override string ToString()
        {
            return $"{ID,7} {User.UserName,-10} {Product.Name,-20} {string.Format("{0:0.00}", Amount),10}, {Date.ToShortDateString(),-10} purchase transaction";
        }
    }
}
