using CharlieV2._0.interfaces;
using CharlieV2._0.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class Factory : IDepartment
    {
        
        public int DailyProductionUnits { get; set; }
        public DailyProduction DailyProduction { get; set; }
        public RawMaterialsWarehouse RawMaterialsWarehouse { get; set; }
        public ProductWarehouse ProductWarehouse { get; set; }
        public List<IEmployee> Employees { get; set; }
        public IReport DailyReport { get; set; }

        public Factory(int dailyProductionUnits)
        {           
            RawMaterialsWarehouse = new RawMaterialsWarehouse();
            ProductWarehouse = new ProductWarehouse();
            Employees = new List<IEmployee>();
            DailyProductionUnits = dailyProductionUnits;           
        }

        public void WorkingDay(DateTime today)
        {          
            DailyProduction = new DailyProduction(DailyProductionUnits);
            RawMaterialsWarehouse.Quantity = RawMaterialsWarehouse.Quantity - DailyProduction.DailyRawMaterialUsed();
            ProductWarehouse.Chocolates.AddRange(DailyProduction.Chocolates);
                    
            RawMaterialsWarehouse.CheckResupply();           
            Console.WriteLine(RawMaterialsWarehouse.Quantity);            
        }

        public void Initialize()
        {
            SupplyServices supplyServices = new SupplyServices();
            supplyServices.GetOffers();
            RawMaterialsWarehouse.InitialQuantity = supplyServices.ChooseOffer().Quantity;
            RawMaterialsWarehouse.Quantity = RawMaterialsWarehouse.InitialQuantity;
        }

        public IReport CreateDailyReport(DateTime today)
        {
            return new FactoryDailyReport(DailyProduction.BlackDailyProduction.ChocosPerDay, DailyProduction.WhiteDailyProduction.ChocosPerDay,
                DailyProduction.MilkDailyProduction.ChocosPerDay, today);
        }
    }
}
