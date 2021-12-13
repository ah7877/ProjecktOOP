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
            Console.WriteLine("Products");
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("Users");
            List<User> users = ReadData.ReadUserFile();
            foreach (User u in users)
            {
                Console.WriteLine(u.AllUserData());
            }

            Console.WriteLine("InsertCashTransactions");
            InsertCashTransaction tom = new InsertCashTransaction(users[1], 5);
            tom.Execute();
            Console.WriteLine(tom.ToString());
            Console.WriteLine(users[1].AllUserData());

            Console.WriteLine("InsertCashTransactions");
            BuyTransaction tim = new BuyTransaction(products[1], users[1]);
            tim.Execute();
            Console.WriteLine(tim.ToString());
            Console.WriteLine(users[1].AllUserData());

            //TallySystem stregsystem = new TallySystem();
            //TallySystemUI ui = new StregsystemCLI(stregsystem);
            //StregsystemController sc = new StregsystemController(ui, stregsystem);
            //ui.Start();
        }
    }
}
