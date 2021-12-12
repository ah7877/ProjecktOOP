using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using OOPEksamensOpgave.Models;

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
                productList.Add(new Product(Convert.ToInt32(productVariables[0]), productVariables[1], Convert.ToDecimal(productVariables[2])/100, Convert.ToBoolean(Convert.ToInt32(productVariables[3]))));
                //since there is no startDate on any products every poduct is currently listed as a regular product
            }
            return productList;
        }

        public static List<User> ReadUserFile()
        {
            List<User> UserList = new List<User>();

            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\Data\\users.csv");

            for (int i = 1; i < lines.Length; i++)
            {
                string[] userVariables = lines[i].Split(",");
                UserList.Add(new User(Convert.ToUInt32(userVariables[0]), userVariables[1], userVariables[2], userVariables[3], userVariables[5], Convert.ToDecimal(userVariables[4]) / 100));
            }
            return UserList;
        }
    }
}
