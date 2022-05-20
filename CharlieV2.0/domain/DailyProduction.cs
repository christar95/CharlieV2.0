using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class DailyProduction
    {
        public int TotalUnits { get; set; }
        public BlackDailyProduction BlackDailyProduction { get; set; }
        public MilkDailyProduction MilkDailyProduction { get; set; }
        public WhiteDailyProduction WhiteDailyProduction { get; set; }
        public List<IChocolate> Chocolates { get; set; }

        public DailyProduction(int dailyProductionUnits)
        {
            TotalUnits = dailyProductionUnits;
            BlackDailyProduction = new BlackDailyProduction(TotalUnits);
            MilkDailyProduction = new MilkDailyProduction(TotalUnits);
            WhiteDailyProduction = new WhiteDailyProduction(TotalUnits);
            Chocolates = new List<IChocolate>();
            Chocolates.AddRange(BlackDailyProduction.Create());
            Chocolates.AddRange(MilkDailyProduction.Create());
            Chocolates.AddRange(WhiteDailyProduction.Create());
         
        }

        public double DailyRawMaterialUsed()
        {
            double dailyRawMaterialsUsed = 0;
            foreach (var choco in Chocolates)
            {
                dailyRawMaterialsUsed = dailyRawMaterialsUsed + choco.KilosPerUnit;
            }
            return dailyRawMaterialsUsed;
        }
    }
}
