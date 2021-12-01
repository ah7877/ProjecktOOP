using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    public class User : IComparable 
    {
        public delegate int UserBalanceNotification(User user, decimal balance);

        private int _id;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _email;
        private decimal _balance;

        /*
            implimentationer der mangler
            en delegate til at smide en besked til når brugeren har mindre end 50 kr på kontoen
                UserBalaceNotification(User user, decimal balance)
            ToString
                Retunerer Fornavn(e) Efternavn (Email)
            EqualsMethod samt GetHashCode
            impliment IComparable, sortere på ID
            fornuftig Constructer
         */

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }



        public int ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
