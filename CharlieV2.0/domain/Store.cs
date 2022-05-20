using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class Store : IDepartment
    {
        
        public StoreWarehouse StoreWarehouse { get; set; }
        public double DailyEarnings { get; set; }
        Random rand = new Random();
        Random rand2 = new Random();
       
        
        public IReport DailyReport { get; set; }
        public List<IEmployee> Employees { get; set; }
       

        public Store()
        {         
            StoreWarehouse = new StoreWarehouse();
        }

        public void WorkingDay(DateTime today)
        {
            StoreWarehouse.InventoryAmountOfChocolates();
            Console.WriteLine($"Before sales, B: {StoreWarehouse.AmountOfBlackChocolates}, W: {StoreWarehouse.AmountOfWhiteChocolates}, M: {StoreWarehouse.AmountOfMilkChocolates}");
            ChocolateSales(today);
            Console.WriteLine($"After sales, B: {StoreWarehouse.AmountOfBlackChocolates}, W: {StoreWarehouse.AmountOfWhiteChocolates}, M: {StoreWarehouse.AmountOfMilkChocolates}");
            
        }


        public void ChocolateSales(DateTime today)
        {
            int salesPerDay = rand.Next(StoreWarehouse.Chocolates.Count / 2, StoreWarehouse.Chocolates.Count + 1);
            int amountOfGifts = 0;
            int nameCounter = 1;
            while (salesPerDay > 0)                 
            {
                double totalCost = 0;
                int chokosPerPurchase = rand.Next(0, salesPerDay + 1); 
                Customer customer = new Customer($"Customer {nameCounter}");                                   
                for (int i = 0; i < chokosPerPurchase; i++)
                {
                    int index = rand2.Next(0,StoreWarehouse.Chocolates.Count); //+1
                    totalCost = totalCost + StoreWarehouse.Chocolates[index].UnitPrice;
                    StoreWarehouse.RefreshAmountOfChocolates(StoreWarehouse.Chocolates[index]);
                    StoreWarehouse.Chocolates.RemoveAt(index);
                }
                if (isSecondTuesday(today))
                    totalCost = totalCost * 0.8;

                customer.PayAmount(totalCost);
                amountOfGifts = GiveGiftExperimentToCustomer(totalCost);
                nameCounter++;
                DailyEarnings += totalCost;
                salesPerDay -= chokosPerPurchase;
            }
        }
        public IReport CreateDailyReport(DateTime today)
        {
            return new StoreDailyReport(StoreWarehouse.DailySoldBlackChocolates, StoreWarehouse.DailySoldMilkChocolates, StoreWarehouse.DailySoldWhiteChocolates, DailyEarnings, today);
        }

        bool isSecondTuesday(DateTime t) // checking if the current day is the second Tuesday of the current month
        {
            //return (t.Date == SecondTuesday(t).Date) ? true : false;
            return (t == SecondTuesday(t)) ? true : false;
        }

        DateTime SecondTuesday(DateTime t)
        {
            var secondTuesDay = new DateTime();
            var firstOfMonth = new DateTime(t.Year, t.Month, 1); // finding the 1st day of the current month
            switch (firstOfMonth.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    secondTuesDay = firstOfMonth.AddDays(8);
                    return secondTuesDay;
                case DayOfWeek.Tuesday:
                    secondTuesDay = firstOfMonth.AddDays(7);
                    return secondTuesDay;
                case DayOfWeek.Wednesday:
                    secondTuesDay = firstOfMonth.AddDays(13);
                    return secondTuesDay;
                case DayOfWeek.Thursday:
                    secondTuesDay = firstOfMonth.AddDays(12);
                    return secondTuesDay;
                case DayOfWeek.Friday:
                    secondTuesDay = firstOfMonth.AddDays(11);
                    return secondTuesDay;
                case DayOfWeek.Saturday:
                    secondTuesDay = firstOfMonth.AddDays(10);
                    return secondTuesDay;
                case DayOfWeek.Sunday:
                    secondTuesDay = firstOfMonth.AddDays(9);
                    return secondTuesDay;
                default:
                    return secondTuesDay; // returning the second Tuesday of the current month
            }
        }

        
        public int GiveGiftExperimentToCustomer(double totalCost)
        {
            int ammountOfGifts = 0;
          
            if (StoreWarehouse.ExpChocolates.Count == 0) // this list is filled after the 1st year of production
            {
                Console.WriteLine("Bad luck, come NEXT YEAR FOR GIFT!!");
            }
            else
            {
                ammountOfGifts = (int)totalCost / 30;              // calculating how many gifts to give according to the total cost      
                for (int i = 0; i < ammountOfGifts; i++)
                {
                    if (StoreWarehouse.ExpChocolates.Count != 0)
                    {
                                                                     //we add the gifts to the purchase and remove them from the store list
                        StoreWarehouse.ExpChocolates.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, all Gifts are gone, come NEXT YEAR!!");
                        break;
                    }
                }
            }
            return ammountOfGifts;
        }

    }
}
