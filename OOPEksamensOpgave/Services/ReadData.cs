using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using OOPEksamensOpgave.Models;
using OOPEksamensOpgave.Interfaces;

namespace OOPEksamensOpgave.Services
{
    abstract class ReadData
    {
        public static List<Product> ReadProductFile()
        {
            List<Product> productList = new List<Product>();

            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Data\\products.csv");

            for (int i = 1; i < lines.Length; i++)
            {
                    string[] productVariables = lines[i].Split(";");
                    //since there is no startDate on any products every poduct is currently listed as a regular product
                    productList.Add(new Product(Convert.ToUInt32(productVariables[0]), productVariables[1], Convert.ToDecimal(productVariables[2]) / 100, Convert.ToBoolean(Convert.ToInt32(productVariables[3]))));
            }
            return productList;
        }

        public static List<User> ReadUserFile()
        {
            List<User> userList = new List<User>();

            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Data\\users.csv");

            for (int i = 1; i < lines.Length; i++)
            {
                string[] userVariables = lines[i].Split(",");
                userList.Add(new User(Convert.ToUInt32(userVariables[0]), userVariables[1], userVariables[2], userVariables[3], userVariables[5], Convert.ToDecimal(userVariables[4]) / 100));
            }
            return userList;
        }

        //could impliment Transaction Read for semi persistant data but not enough time
        /*
        public static List<Transaction> ReadTransactions(ITallySystem TS)
        {
            List<Transaction> transactionList = new List<Transaction>();

            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Data\\users.csv");
            //$"{ID,7} {User.UserName,-10} {string.Format("{0:0.00}", Amount), 10} {Date.ToShortDateString(),-10} deposit"
            //$"{ID,7} {User.UserName,-10} {Product.Name,-20} {string.Format("{0:0.00}", Amount),10}, {Date.ToShortDateString(),-10} purchase";
            for (int i = 1; i < lines.Length; i++)
            {
                string[] userVariables = lines[i].Split(",");

                transactionList.Add(new BuyTransaction();
            }
            return transactionList;
        }
        */
    }
}
