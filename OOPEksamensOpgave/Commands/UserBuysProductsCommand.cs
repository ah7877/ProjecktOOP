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
    class UserBuysProductsCommand : ICommand
    {
        private ITallySystem ts;
        private ITallySystemUI ui;
        private string[] commands;

        public UserBuysProductsCommand(ITallySystem ts, ITallySystemUI ui, string[] commands)
        {
            this.ts = ts;
            this.commands = commands;
            this.ui = ui;
        }

        public void Execute()
        {
            User user = ts.GetUserByUsername(commands[0]);

            for (int i = 1; i < commands.Length; i++)
            {
                BuyTransaction transaction = ts.BuyProduct(user, ts.GetProductByID(Convert.ToInt32(commands[i])));
                ui.DisplayUserBuysProduct(1, transaction);
            }
        }
    }
}
