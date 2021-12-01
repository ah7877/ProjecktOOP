using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    public class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction() : base()
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
