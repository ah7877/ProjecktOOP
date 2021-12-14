using OOPEksamensOpgave.Interfaces;
using OOPEksamensOpgave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.ModelViewController
{
    class TallySystemUI : ITallySystemUI
    {
        private TallySystem _tS; //tallysystem

        public TallySystemUI(TallySystem tS)
        {
            TS = tS;
        }

        public event StregsystemEvent CommandEntered;

        public void Close()
        {
            Environment.Exit(0);
        }

        public void DisplayAdminCommandNotFoundMessage(string adminCommand)
        {
            Console.WriteLine($"Admin command {adminCommand}, was not recognized");
        }

        public void DisplayGeneralError(string errorString)
        {
            Console.WriteLine(errorString);
        }

        public void DisplayInsufficientCash(User user, Product product)
        {
            throw new NotImplementedException();
        }

        public void DisplayProductNotFound(string productID)
        {
            Console.WriteLine($"A product with id: {productID} could not be found");
        }

        public void DisplayTooManyArgumentsError(string command)
        {
            Console.WriteLine($"Command {command} contains too many arguments");
        }

        public void DisplayUserBuysProduct(int count, BuyTransaction transaction)
        {
            if (count > 1)
                Console.WriteLine($"{count} * {transaction.Product.Name}'s have been purchased.");
            else
                Console.WriteLine($"{transaction.Product.Name} has been purchased.");

        }

        public void DisplayUserInfo(User user)
        {
            Console.WriteLine(user);
        }

        public void DisplayUserNotFound(string username)
        {
            Console.WriteLine($"User: {username} could not be found");
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine($"{"ID",5}{"Product",-20}{"Price",10}");

            IEnumerable<Product> products = TS.ActiveProducts();
            foreach (Product p in products)
            {
                Console.WriteLine(p.ToString());
            }

        }

        public TallySystem TS
        {
            get { return _tS; }
            set { _tS = value; }
        }
    }
}
