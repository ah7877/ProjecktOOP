using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    public abstract class Transaction
    {
        private uint _id;
        private static uint _nextID = 1;
        private User _user;
        private DateTime _date;
        private decimal _amount;

        protected Transaction(User user, decimal amount)
        {
            User = user;
            Amount = amount;
            Date = DateTime.Now;
            ID = NextID++;
        }


        public abstract void Execute();

        public abstract override string ToString();


        public uint ID
        {
            get { return _id; }
            private set { _id = value; }
        }
        public uint NextID
        {
            get { return _nextID; }
            private set { _nextID = value; }
        }

        public User User
        {
            get { return _user; }
            set 
            {
                    if (value == null)
                    {
                        throw new NullReferenceException("A Transaction must contain a user");
                    }
                    else
                        _user = value;
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
