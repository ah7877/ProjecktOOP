using System;
using System.Collections.Generic;
using OOPEksamensOpgave.Models;
using OOPEksamensOpgave.Exeptions;
using OOPEksamensOpgave.Services;
using OOPEksamensOpgave.Controller;
using OOPEksamensOpgave.ModelViewController;
using System.IO;


namespace OOPEksamensOpgave
{
    public delegate int UserBalanceNotification(User user, decimal balance);
    public delegate int StregsystemEvent(User user, decimal balance);

    class Program
    {
        static void Main(string[] args)
        {
            TallySystem ts = new TallySystem();
            TallySystemUI ui = new TallySystemUI(ts);
            TallySystemController tsc = new TallySystemController(ts, ui);
            ui.Start();
        }
    }
}
