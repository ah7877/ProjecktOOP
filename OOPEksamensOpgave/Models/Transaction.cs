using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    abstract class Transaction
    {
        private int _id;
        private User _user;
        private DateTime _date;
        private int _amount;


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
            return "hej";
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
