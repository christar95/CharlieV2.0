using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class WhiteChocolate : IChocolate
    {
        public double KilosPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public WhiteChocolate()
        {
            KilosPerUnit = 0.03;
            UnitPrice = 1.3;
        }
        public WhiteChocolate(double kilos, double price)
        {
            KilosPerUnit = kilos;
            UnitPrice = price;

        }
    }
}
