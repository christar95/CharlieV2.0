using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class RawMaterialsWarehouse
    {
        public double InitialQuantity { get; set; }

        public double Quantity { get; set; }

        public double ExperimentalQuantity { get; set; }

        public void CheckResupply()
        {
            //DailyProduction production = new DailyProduction();

            if (Quantity < InitialQuantity * 0.1)
            {
                Console.WriteLine("SUPPLIEESSSSS");
                Quantity = Quantity + InitialQuantity;
                Console.WriteLine($"new Quantity = {Quantity}");

            }
        }
    }
}
