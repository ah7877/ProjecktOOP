using System;
using System.Collections.Generic;
using OOPEksamensOpgave.Models;
using OOPEksamensOpgave.Exeptions;
using OOPEksamensOpgave.Services;
using System.IO;





namespace OOPEksamensOpgave
{
    public delegate int UserBalanceNotification(User user, decimal balance);
    public delegate int StregsystemEvent(User user, decimal balance);

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ReadData.ReadProductFile();
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }
            Console.ReadLine();
            List<User> users = ReadData.ReadUserFile();
            foreach (User u in users)
            {
                Console.WriteLine(u.AllUserData());
            }
            Console.ReadLine();

            //TallySystem stregsystem = new TallySystem();
            //TallySystemUI ui = new StregsystemCLI(stregsystem);
            //StregsystemController sc = new StregsystemController(ui, stregsystem);
            //ui.Start();
        }
    }
}
