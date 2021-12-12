using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    public class User : IComparable 
    {
        private uint _id;
        private static uint _nextID = 1;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _email;
        private decimal _balance;

        public User(string firstName, string lastName, string userName, string email, decimal balance)
        {
            _firstName = firstName;
            _lastName = lastName;
            _userName = userName;
            _email = email;
            _balance = balance;

            ID = NextID++;
        }

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
            if (obj == null) return 1;

            User user = obj as User;
            if (user != null)
                return this.ID.CompareTo(user.ID);
            else
                throw new ArgumentException("Object is not a User");
        }


        public override int GetHashCode()
        {
            try
            {
                return (int) ID;
            }
            catch
            {
                throw new ArgumentException("ID out of int range");
            }
        }

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



        private bool UsernameValidation (string name)
        {
            foreach (char item in name)
            {
                if(!char.IsDigit(item) && !Char.IsLower(item) && item != '_')
                {
                    return false;
                }
            }
            return true;
        }

        private bool EmailValidation(string email)
        {
            string[] emailParts = email.Split('@');
            if (emailParts.Length != 2)
            {
                return false;
            }

            foreach (char item in emailParts[0])
            {
                if (!char.IsDigit(item) && !char.IsLetter(item) && item != '_' && item != '.' && item != '-')
                {
                    return false;
                }
            }

            foreach (char item in emailParts[1])
            {
                if (!char.IsDigit(item) && !char.IsLetter(item) && item != '.' && item != '-')
                {
                    return false;
                }
            }

            if (!emailParts[1].Contains(".") || emailParts[1].StartsWith(".") || emailParts[1].StartsWith("-") || emailParts[1].EndsWith(".") || emailParts[1].EndsWith("-"))
                return false;

            return true;
        }





        public uint ID
        {
            get { return _id; }
            private set { _id = value; }
        }

        public static uint NextID
        {
            get { return _nextID; }
            set { _nextID = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("First Name can not be null");
                }
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
                    throw new ArgumentException("Last Name can not be null");
                }
                _lastName = value; 
            }
        }

        public string UserName
        {
            get { return _userName; }
            set 
            {
                if (UsernameValidation(value))
                {
                    _userName = value;
                }
                else
                    throw new ArgumentException("Username can only contain digits, lowercase letters and underscore");
            }
        }

        public string Email
        {
            get { return _email; }
            set 
            {
                if (EmailValidation(value))
                {
                    _email = value;
                }
                else
                    throw new ArgumentException("local-part@domain: Local part can only contain letters, numbers, dot\".\", underscore\"_\" and hyphen\"-\"");

            }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
