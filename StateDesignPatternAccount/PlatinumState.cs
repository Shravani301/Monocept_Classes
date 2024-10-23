using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal class PlatinumState:IState
    {
        private const double MinBalance = 25000;
        private const double MaxBalance = double.MaxValue; 

        public void GetBenefits()
        {
            Console.WriteLine("Platinum Benefits");
        }

        public bool IsInRange(double balance)
        {
            return balance >= MinBalance && balance <= MaxBalance;
        }
    }
}
