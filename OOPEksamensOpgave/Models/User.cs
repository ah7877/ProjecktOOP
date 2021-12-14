using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Exeptions;

namespace OOPEksamensOpgave.Models
{
    public class User : IComparable
    {
        //since the only time a user is added there is no validation on the id
        //i assume the ID is given by another program that writes in the users.csv in Data file with an agreed upon syntax for user data
        private uint _id;
        private static uint _nextID = 1;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _email;
        private decimal _balance;

        public User(uint id, string firstName, string lastName, string userName, string email, decimal balance = 0)
        {
            ID = id;
            NextID = id + 1;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Balance = balance;
        }

        public User(string firstName, string lastName, string userName, string email, decimal balance = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Balance = balance;
            ID = NextID++;

        }

        //returns all userdata
        public string AllUserData()
        {
            return $"{ID,7} {FirstName,-10} {LastName,-10} {UserName,-10} {Email,-10} {string.Format("{0:0.00}", Balance),10}";
        }

        public override string ToString()
        {
            return $"{FirstName,-10} {LastName,-10}";
        }

        //makes User comparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            User user = obj as User;
            if (user != null)
                return this.ID.CompareTo(user.ID);
            else
                throw new ArgumentException("Object is not a User");
        }

        //overrides Equalsmethod and checks on username instead
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                User user = (User)obj;
                return (this.UserName == user.UserName);
            }
        }

        //checks if the username is valid
        private bool UsernameIsValid(string name)
        {
            foreach (char item in name)
            {
                if (!char.IsDigit(item) && !Char.IsLower(item) && item != '_')
                {
                    return false;
                }
            }
            return true;
        }

        //checks if the email is valid
        private bool EmailIsValid(string email)
        {
            string[] emailParts = email.Split('@');
            if (emailParts.Length != 2)
            {
                throw new ArgumentException("There can only be one @ in the Email");
            }

            foreach (char item in emailParts[0])
            {
                if (!char.IsDigit(item) && !char.IsLetter(item) && item != '_' && item != '.' && item != '-')
                {
                    throw new ArgumentException("local-part@domain: Local-part can only contain letters, numbers, \".\", \"_\" and \"-\"");
                }
            }

            foreach (char item in emailParts[1])
            {
                if (!char.IsDigit(item) && !char.IsLetter(item) && item != '.' && item != '-')
                {
                    throw new ArgumentException("local-part@domain: Domain can only contain letters, numbers, \".\" and \"-\"");
                }
            }

            if (!emailParts[1].Contains(".") || emailParts[1].StartsWith(".") || emailParts[1].StartsWith("-") || emailParts[1].EndsWith(".") || emailParts[1].EndsWith("-"))
                throw new ArgumentException("local-part@domain: Domain can not start or end with \".\" or \"-\"");

            return true;
        }

        //uses id and username to generate a hash code since both should be uniqe variabels
        public override int GetHashCode()
        {
            return HashCode.Combine(ID, UserName);
        }

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

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("First Name of User can not be null");
                }
                else
                    _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Last Name of User can not be null");
                }
                else
                    _lastName = value;
            }
        }

        public string UserName
        {
            get { return _userName; }
            set
            {

                if (!UsernameIsValid(value))
                {
                    throw new ArgumentException("Username can only contain digits, lowercase letters and underscore");
                }
                else
                    _userName = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (EmailIsValid(value))
                {
                    _email = value;
                }
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
