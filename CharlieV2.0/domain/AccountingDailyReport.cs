using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class AccountingDailyReport:IReport
    {
        public DateTime AccountingDate { get; set; }
        
        public AccountingDailyReport(DateTime today)
        {
            AccountingDate = today;
        }
    }
}
