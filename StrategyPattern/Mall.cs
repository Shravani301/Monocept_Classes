using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Mall:IStrategyPayment
    {
        IStrategyPayment strategyPayment;
        public Mall(IStrategyPayment paymentType)
        {
            strategyPayment = paymentType;
        }
        public string MakePayment()
        {
            return strategyPayment.MakePayment();
        }
    }
}
