using System;
using OOPEksamensOpgave.Models;

namespace OOPEksamensOpgave
{
    public delegate int UserBalanceNotification(User user, decimal balance);
    
    class Program
    {

        static void Main(string[] args)
        {
            TallySystem stregsystem = new TallySystem();
            TallySystemUI ui = new StregsystemCLI(stregsystem);
            StregsystemController sc = new StregsystemController(ui, stregsystem);
            ui.Start();
        }
    }
}
