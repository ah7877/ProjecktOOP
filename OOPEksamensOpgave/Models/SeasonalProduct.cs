using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEksamensOpgave.Models
{
    public class SeasonalProduct : Product
    {
        private DateTime _seasonStartDate;
        private DateTime _seasonEndDate;

        /*
         Noget der checker om den er i season
         */

        public DateTime SeasonStartDate
        {
            get { return _seasonStartDate; }
            set { _seasonStartDate = value; }
        }

        public DateTime SeasonEndDate
        {
            get { return _seasonEndDate; }
            set { _seasonEndDate = value; }
        }
    }
}
