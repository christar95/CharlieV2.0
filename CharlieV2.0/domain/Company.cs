using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class Company
    {
        public List<Factory> Factories { get; set; }
        public List<Store> Stores { get; set; }
        public AccountingDepartment Accounting { get; set; }
        public int ProductionUnitsPerFactory { get; set; } = 500;

        public Company()
        {            
            Factories = new List<Factory>() { new Factory(ProductionUnitsPerFactory) };
            Stores = new List<Store>() { new Store() };
            Accounting = new AccountingDepartment();
        }

        public void Start()
        {
            var today = new DateTime(2022, 12, 30);
            //today = DateTime.Now.Date;
            Factories[0].Initialize();
            for (int days=0; days<5; days++)
            {
                for (int branch =0; branch<Factories.Count; branch++)
                {
                    if (today.Day==31 &&today.Month==12)
                        Factories[branch].Initialize();
                    Factories[branch].WorkingDay(today);
                    FactoryResupplyStore(branch);
                    Stores[branch].WorkingDay(today);
                    Accounting.DailyReports.Add(Stores[branch].CreateDailyReport(today));
                    
                }               
            }
            
        }


        public void FactoryResupplyStore(int index)
        {
            ResupplyStoreWithBlack(index);
            ResupplyStoreWithWhite(index);
            ResupplyStoreWithMilk(index);
        }

        public void ResupplyStoreWithBlack(int index)
        {
            int AmountOfBlack = Stores[index].StoreWarehouse.AmountOfBlackChocolates;
            int maxAmountOfBlack = (ProductionUnitsPerFactory / 2) * 3 / 5;
            if (Stores[index].StoreWarehouse.AmountOfBlackChocolates < maxAmountOfBlack * 0.25)
            {
                for (int i = 0; i < Factories[index].ProductWarehouse.Chocolates.Count; i++)
                {
                    if (Factories[index].ProductWarehouse.Chocolates[i] is BlackChocolate)
                    {
                        Stores[index].StoreWarehouse.Chocolates.Add(Factories[index].ProductWarehouse.Chocolates[i]);
                        Factories[index].ProductWarehouse.Chocolates.RemoveAt(i);
                        AmountOfBlack++;                       
                    }
                    if (AmountOfBlack == maxAmountOfBlack)
                        break;
                }
            }
        }

        public void ResupplyStoreWithWhite(int index)
        {
            int AmountOfWhite = Stores[index].StoreWarehouse.AmountOfWhiteChocolates;
            int maxAmountOfWhite = (ProductionUnitsPerFactory / 2) * 1 / 5;
            if (Stores[index].StoreWarehouse.AmountOfWhiteChocolates < maxAmountOfWhite * 0.25)
            {
                for (int i = 0; i < Factories[index].ProductWarehouse.Chocolates.Count; i++)
                {
                    if (Factories[index].ProductWarehouse.Chocolates[i] is WhiteChocolate)
                    {
                        Stores[index].StoreWarehouse.Chocolates.Add(Factories[index].ProductWarehouse.Chocolates[i]);
                        Factories[index].ProductWarehouse.Chocolates.RemoveAt(i);
                        AmountOfWhite++;
                        
                    }
                    if (AmountOfWhite == maxAmountOfWhite)
                        break;
                }
            }
        }

        public void ResupplyStoreWithMilk(int index)
        {
            int AmountOfMilk = Stores[index].StoreWarehouse.AmountOfMilkChocolates;
            int maxAmountOfMilk = (ProductionUnitsPerFactory / 2) * 1 / 5;
            if (Stores[index].StoreWarehouse.AmountOfMilkChocolates < maxAmountOfMilk * 0.25)
            {
                for (int i = 0; i < Factories[index].ProductWarehouse.Chocolates.Count; i++)
                {
                    if (Factories[index].ProductWarehouse.Chocolates[i] is MilkChocolate)
                    {
                        Stores[index].StoreWarehouse.Chocolates.Add(Factories[index].ProductWarehouse.Chocolates[i]);
                        Factories[index].ProductWarehouse.Chocolates.RemoveAt(i);
                        AmountOfMilk++;
                        
                    }
                    if (AmountOfMilk == maxAmountOfMilk)
                        break;
                }
            }
        }


    }
}
