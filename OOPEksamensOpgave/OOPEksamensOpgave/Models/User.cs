using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _email;
        private int _balance;

        /*
         * implimentationer der mangler
            ToString
                Retunerer Fornavn(e) Efternavn (Email)
            EqualsMethod samt GetHashCode
            impliment IComparable, sortere på ID
            fornuftig Constructer
         */








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

        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
