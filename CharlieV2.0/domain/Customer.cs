using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class Customer
    {
        Random rand = new Random();
        public string LastName { get; private set; }
        private Wallet Wallet;

        public Customer(string lastname)
        {
            LastName = lastname;
            Wallet = new Wallet(rand.Next(10,40));
        }
        public void PayAmount(double amountToPay)
        {
            if (Wallet.Value >= amountToPay)
                Wallet.SubMoney(amountToPay);

        }

        public override string ToString()
        {
            return $"{LastName} : {Wallet.Value}";
        }
    }
}
