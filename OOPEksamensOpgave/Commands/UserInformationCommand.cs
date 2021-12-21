using OOPEksamensOpgave.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Models;
using OOPEksamensOpgave.ModelViewController;

namespace OOPEksamensOpgave.Commands
{
    class UserInformationCommand : ICommand
    {
        private ITallySystem ts;
        private ITallySystemUI ui;
        private string[] commands;

        public UserInformationCommand(ITallySystem ts, ITallySystemUI ui, string[] commands)
        {
            this.ts = ts;
            this.commands = commands;
            this.ui = ui;
        }

        public void Execute()
        {

        }
    }
}
