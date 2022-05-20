using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class Wallet
    {
        public double Value { get; private set; }
        public void AddMoney(float amount)
        {
            Value += amount;
        }
        public Wallet(double initialAmount)
        {
            Value = initialAmount;
        }
        public void SubMoney(double amount)
        {
            Value -= amount;
        }
    }
}
