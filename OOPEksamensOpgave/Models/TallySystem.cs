using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Interfaces;
using OOPEksamensOpgave.Services;
using OOPEksamensOpgave.Exeptions;

namespace OOPEksamensOpgave.Models
{
    public class TallySystem : ITallySystem
    {
        public event UserBalanceNotification UserBalanceWarning;
        private List<User> _users = ReadData.ReadUserFile();
        private List<Product> _products = ReadData.ReadProductFile();
        private List<Transaction> _transactions = new();
        public List<User> Users
        {
            get { return _users; }
            private set { _users = value; }
        }
        public List<Product> Products
        {
            get { return _products; }
            private set { _products = value; }
        }
        public List<Transaction> Transactions
        {
            get { return _transactions; }
            private set { _transactions = value; }
        }

        public IEnumerable<Product> ActiveProducts()
        {
            List<Product> list = new();
            foreach (Product p in Products)
            {
                if (p.IsActive == true)
                {
                    list.Add(p);
                }
            }
            return list;
        }

        public InsertCashTransaction AddCreditsToAccount(User user, decimal amount)
        {
            InsertCashTransaction transaction = new(user, amount);
            transaction.Execute();
            Transactions.Add(transaction);
            return transaction;
        }

        public BuyTransaction BuyProduct(User user, Product product)
        {

            if (user.Balance > product.Price || product.CanBeBoughtOnCredit == true)
            {
                BuyTransaction transaction = new BuyTransaction(product, user);
                transaction.Execute();
                Transactions.Add(transaction);
                return transaction;
            }
            else
            throw new InsufficientCreditsException(user, product);
        }

        public Product GetProductByID(int id)
        {
            foreach(Product p in Products)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            throw new ProductNotFoundException(Convert.ToString(id));
        }

        public IEnumerable<Transaction> GetTransactions(User user, int count)
        {
            List <Transaction> tList= new();
            foreach (Transaction t in Transactions)
            {
                if (t.User == user)
                {
                    tList.Add(t);
                    if (tList.Count > count)
                        break;
                }
            }
            return tList;
        }

        public User GetUserByUsername(string username)
        {
            foreach (User u in Users)
            {
                if (u.UserName == username)
                {
                    return u;
                }
            }
            throw new UserNotFoundException(username);
        }

        public User GetUsers(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

    }
}
