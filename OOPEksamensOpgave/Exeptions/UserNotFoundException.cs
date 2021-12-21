using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Exeptions
{
    class UserNotFoundException : Exception
    {
        private string _username;

        public UserNotFoundException(string username)
        {
            Username = username;
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

    }
}
