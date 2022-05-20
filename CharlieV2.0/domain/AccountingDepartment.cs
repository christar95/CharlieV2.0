using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class AccountingDepartment : IDepartment
    {
        public List<IReport> DailyReports { get; set; }
        public List<double> EarningsPerYear { get; set; }
        public List<List<StoreDailyReport>> YearlyDailyReports { get; set; }
        public IReport DailyReport { get; set; }

        public AccountingDepartment()
        {
            DailyReports = new List<IReport>();
            EarningsPerYear = new List<double>();
            YearlyDailyReports = new List<List<StoreDailyReport>>();
        }
        public void WorkingDay(DateTime today)
        {
            
        }

        public IReport CreateDailyReport(DateTime today)
        {
            return new AccountingDailyReport(today);
        }
    }
}
