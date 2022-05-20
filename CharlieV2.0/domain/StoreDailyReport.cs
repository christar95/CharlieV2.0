using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class StoreDailyReport : IReport
    {
        public DateTime SalesDate { get; set; }
        public int AmountOfSoldBlack { get; set; }
        public int AmountOfSoldWhite { get; set; }
        public int AmountOfSoldMilk { get; set; }
        public double DailyEarnings { get; set; }

        public StoreDailyReport(int amountOfSoldBlack, int amountOfSoldWhite, int amountOfSoldMilk, double dailyEarnings, DateTime today)
        {
            AmountOfSoldBlack = amountOfSoldBlack;
            AmountOfSoldWhite = amountOfSoldWhite;
            AmountOfSoldMilk = amountOfSoldMilk;
            DailyEarnings = dailyEarnings;
            SalesDate = today;

        }
    }
}
