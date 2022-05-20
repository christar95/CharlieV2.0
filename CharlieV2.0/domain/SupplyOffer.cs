using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    enum Quality//na ginei integer?

    {
        A = 1,
        B = 2,
        C = 3
    }
    class SupplyOffer
    {
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private int _quality;

        public int Quallity
        {
            get { return _quality; }
            set { _quality = value; }
        }

        private double _pricePerKilo;

        public double PricePerKilo
        {
            get { return _pricePerKilo; }
            set { _pricePerKilo = value; }
        }

        public SupplyOffer(int quantity, int quality, double pricePerKilo)
        {
            Quantity = quantity;
            Quallity = quality;
            PricePerKilo = pricePerKilo;
        }
        public SupplyOffer()
        {

        }
    }
}
