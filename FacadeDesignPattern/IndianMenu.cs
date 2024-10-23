using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class IndianMenu:IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Indian Menu:\n" +
                "1.Idly\n" +
                "2.Dosa\n");               

        }
    }
}
