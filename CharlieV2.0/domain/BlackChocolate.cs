using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class BlackChocolate:IChocolate
    {
        public double KilosPerUnit { get; set; }
        public double UnitPrice { get; set; }

        public BlackChocolate()
        {
            KilosPerUnit = 0.02;
            UnitPrice = 1;
        }
        public BlackChocolate(double kilos, double price)
        {
            KilosPerUnit = kilos;
            UnitPrice = price;
        }
    }
}
