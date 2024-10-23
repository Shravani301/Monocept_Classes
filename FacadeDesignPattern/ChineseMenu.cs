using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class ChineseMenu:IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Chinese Menu:\n" +
                "1.Noodles\n" +
                "2.Spring roll\n");
        }

    }
}
