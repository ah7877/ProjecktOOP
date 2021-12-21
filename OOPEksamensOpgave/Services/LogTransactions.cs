using OOPEksamensOpgave.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Services
{
    public class LogTransactions
    {
        public static async void LogATransaction(Transaction t)
        {
            using StreamWriter file = new(Directory.GetCurrentDirectory() + "\\Data\\TransactionLog.csv", append: true);

            await file.WriteLineAsync(t.ToString());
        }
    }
}
