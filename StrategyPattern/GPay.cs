using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class GPay:IStrategyPayment
    {
        public string MakePayment()
        {
            return "Payment Success through Gpay";
        }

    }
}
