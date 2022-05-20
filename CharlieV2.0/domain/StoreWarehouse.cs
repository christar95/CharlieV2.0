using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class StoreWarehouse
    {
        public int AmountOfBlackChocolates { get; set; }
        public int AmountOfWhiteChocolates { get; set; }
        public int AmountOfMilkChocolates { get; set; }
        public int DailySoldBlackChocolates { get; set; }
        public int DailySoldWhiteChocolates { get; set; }
        public int DailySoldMilkChocolates { get; set; }
        public int AmountOfExpChocolates { get; set; }

        public List<IChocolate> ExpChocolates { get; set; }
        public List<IChocolate> Chocolates { get; set; }

        public StoreWarehouse()
        {
            Chocolates = new List<IChocolate>();
            ExpChocolates = new List<IChocolate>();
        }

        public void InventoryAmountOfChocolates()
        {
            foreach (var chocolate in Chocolates)
            {
                if (chocolate is BlackChocolate)
                {
                    AmountOfBlackChocolates++;
                }
                if (chocolate is WhiteChocolate)
                {
                    AmountOfWhiteChocolates++;
                }
                if (chocolate is MilkChocolate)
                {
                    AmountOfMilkChocolates++;
                }

            }
        }
        public void RefreshAmountOfChocolates(IChocolate chocolate)
        {           
            if(chocolate is BlackChocolate)
            {
                AmountOfBlackChocolates--;
                DailySoldBlackChocolates++;
            }
            if (chocolate is WhiteChocolate)
            {
                AmountOfWhiteChocolates--;
                DailySoldWhiteChocolates++;
            }
            if (chocolate is MilkChocolate)
            {
                AmountOfMilkChocolates--;
                DailySoldMilkChocolates++;
            }           
        }

        public void ChechResupply()
        {

        }


        //public void CheckAmountOfChocolates()
        //{
        //    {
        //        Customer customer = CustromerMockRepository.GetCustomer();
        //        List<IProduct> cart = ProductMockRepository.AddSampleData();

        //        foreach (IProduct product in cart)
        //        {
        //            product.ShipItem(customer);
        //            if (product is IDigitalProduct digital)
        //            {
        //                Console.WriteLine($"For the digital title{digital.Title} you have {digital.TotalDownloadsLeft}.");
        //            }
        //        }
        //    }
        //}
        //public bool CheckResupplyBlack() //checking if the store need resupply
        //{
        //    return (BlackChocoList.Count < DailyStartingAmountBlack * 0.25) ? true : false;
        //}

        //public bool CheckResupplyWhite()
        //{
        //    return (WhiteChocoList.Count < DailyStartingAmountWhite * 0.25) ? true : false;
        //}

        //public bool CheckResupplyMilk()
        //{
        //    return (MilkChocoList.Count < DailyStartingAmountMilk * 0.25) ? true : false;
        //}
    }
}
