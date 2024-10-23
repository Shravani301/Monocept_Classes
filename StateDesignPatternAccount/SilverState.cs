using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternAccount
{
    internal class SilverState:IState
    {
        public void GetBenefits()
        {
            Console.WriteLine("Silver Benefits");
        }

    }
}
