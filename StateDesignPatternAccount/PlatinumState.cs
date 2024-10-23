using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal class PlatinumState:IState
    {
        public void GetBenefits()
        {
            Console.WriteLine("Platinum Benefits");
        }
    }
}
