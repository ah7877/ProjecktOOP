﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Interfaces;
using OOPEksamensOpgave.Services;

namespace OOPEksamensOpgave.Models
{
    public class TallySystem : ITallySystem
    {
        private List<User> _users = ReadData.ReadUserFile();
        private List<Product> _products = ReadData.ReadProductFile();
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

        public IEnumerable<Product> ActiveProducts()
        {
            List<Product> plst = new();
            foreach(Product p in Products)
            {
                if (p.IsActive==true)
                {
                    plst.Add(p);
                }
            }
            IEnumerable<Product> p = plst;
            return p;
        }

        public event UserBalanceNotification UserBalanceWarning;

        public InsertCashTransaction AddCreditsToAccount(User user, int amount)
        {
            InsertCashTransaction Transaction = new(user, Convert.ToDecimal(amount));
            Transaction.Execute();
            return Transaction;
        }

        public BuyTransaction BuyProduct(User user, Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Transaction> GetTransactions(User user, int count)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public User GetUsers(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

    }
}