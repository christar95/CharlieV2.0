using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    enum MilkChocoType
    {
        Plain,
        Almond,
        Hazelnut
    }
    class MilkChocolate : IChocolate
    {
        public double KilosPerUnit { get; set; }
        public double UnitPrice { get; set; }
        Random rand = new Random();
        public MilkChocoType Type { get; set; }
        public MilkChocolate()
        {
            KilosPerUnit = 0.035;
            UnitPrice = 1.2;
            Type = (MilkChocoType)rand.Next(0, 3);
        }
        public MilkChocolate(double kilos, double price, MilkChocoType type)
        {
            KilosPerUnit = kilos;
            UnitPrice = price;
            Type = type;
        }
    }
}
