using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    public abstract class Transaction
    {
        private int _id;
        private User _user;
        private DateTime _date;
        private int _amount;

        protected Transaction(int iD, User user, int amount)
        {
            ID = iD;
            User = user;
            Amount = amount;
            Date = DateTime.Now;
        }


        /*
        implimentationer
            ToString
                ID, user, amount og Date
        Excecute
            udfører transaktionen
        fornuftig constructer
         */


        public abstract void Execute();
        public override string ToString() 
        {
            return $"ID:{ID,-10} User:{User.UserName,-10}, Amount: {Amount,-8}, Date: {Date.ToShortDateString(),-10}";
        }


        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}
