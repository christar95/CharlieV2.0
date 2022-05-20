using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class ProductWarehouse
    {      
        public List<IChocolate> Chocolates { get; set; }

        //duo listes akoma me ta type tou MIlkchocolate

        public ProductWarehouse()
        {           
            Chocolates = new List<IChocolate>();
        }

        public void ResupplyStore(bool needForResupply, List<IChocolate> storeList, List<IChocolate> warehouseList, int amount)
        {
            if (!needForResupply)
                for (int i = 0; storeList.Count < amount; i++)//8elei metavliti
                {
                    storeList.Add(warehouseList[0]);
                    warehouseList.RemoveAt(0);
                }
        }
    }
}
