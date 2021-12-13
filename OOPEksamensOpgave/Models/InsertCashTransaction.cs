using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Services;

namespace OOPEksamensOpgave.Models
{
    public class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(User user, decimal amount) : base(user, amount)
        {
        }

        public override void Execute()
        {
            User.Balance += Amount;
            LogTransactions.LogATransaction(this);
        }

        public override string ToString()
        {
            return $"{ID,7} {User.UserName,-10} {string.Format("{0:0.00}", Amount), 10} {Date.ToShortDateString(),-10} deposit transaction";
        }
    }
}
