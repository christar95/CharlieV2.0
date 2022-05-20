using CharlieV2._0.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.services
{
    class SupplyServices
    {
        Random rand = new Random();
        public SupplyOffer[] Offers { get; set; }
        public SupplyServices()
        {
            Offers = new SupplyOffer[3];
        }


        public void GetOffers()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Getting 3 new offers");
                Console.WriteLine("-------------------------------------------------------------------");
                Offers[i] = new SupplyOffer(rand.Next(5000, 6001), rand.Next(50, 101), rand.Next(5, 21));

            }
        }

        public SupplyOffer ChooseOffer() // Quallity/PricePerKilo, the higher the better, this is our condition
        {
            var bestOffer = Offers[0];

            if (Offers[0].Quallity / Offers[0].PricePerKilo > Offers[1].Quallity / Offers[1].PricePerKilo && Offers[0].Quallity / Offers[0].PricePerKilo > Offers[2].Quallity / Offers[2].PricePerKilo)
            {
                bestOffer = Offers[0];
            }
            if (Offers[1].Quallity / Offers[1].PricePerKilo > Offers[0].Quallity / Offers[0].PricePerKilo && Offers[1].Quallity / Offers[1].PricePerKilo > Offers[2].Quallity / Offers[2].PricePerKilo)
            {
                bestOffer = Offers[1];
            }
            if (Offers[2].Quallity / Offers[2].PricePerKilo > Offers[0].Quallity / Offers[0].PricePerKilo && Offers[2].Quallity / Offers[2].PricePerKilo > Offers[1].Quallity / Offers[1].PricePerKilo)
            {
                bestOffer = Offers[1];
            }

            return bestOffer;
        }
    }
}
