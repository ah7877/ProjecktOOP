using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Interfaces
{
    interface ITallySystemController
    {
        //skal modtage en command fra UI
        //skal dele commands op i strings
        //skal aktivere commands
        public void ParseCommand(string command);
    }
}
