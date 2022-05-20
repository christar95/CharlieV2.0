using CharlieV2._0.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //DailyProduction dailyProduction = new DailyProduction(500);
            //Console.WriteLine(dailyProduction.Chocolates.Count);
            Company company = new Company();
            company.Start();
        }
    }
}
