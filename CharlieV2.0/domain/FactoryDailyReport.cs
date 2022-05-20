using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class FactoryDailyReport: IReport
    {
        public DateTime ProductionDate { get; set; }
        public int AmountBlackProduced { get; set; }
        public int AmountWhiteProduced { get; set; }
        public int AmountMilkProduced { get; set; }

        public FactoryDailyReport(int amountBlackProduced, int amountWhiteProduced, int amountMilkProduced, DateTime today)
        {
            AmountBlackProduced = amountBlackProduced;
            AmountWhiteProduced = amountWhiteProduced;
            AmountMilkProduced = amountMilkProduced;

        }


    }
}
