using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Exeptions
{
    class NameNullExeption : Exception
    {
        public NameNullExeption(string message) : base(message)
        {
        }
    }
}
