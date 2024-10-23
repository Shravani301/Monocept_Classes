using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal class SilverState:IState
    {
        private const double MinBalance = 0;
        private const double MaxBalance = 9999;

        public void GetBenefits()
        {
            Console.WriteLine("Silver Benefits");
        }

        public bool IsInRange(double balance)
        {
            return balance >= MinBalance && balance <= MaxBalance;
        }

    }
}
