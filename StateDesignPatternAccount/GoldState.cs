using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal class GoldState:IState
    {
        private const double MinBalance = 10000;
        private const double MaxBalance = 24999;

        public void GetBenefits()
        {
            Console.WriteLine("Gold Benefits");
        }

        public bool IsInRange(double balance)
        {
            return balance >= MinBalance && balance <= MaxBalance;
        }
    }
}
