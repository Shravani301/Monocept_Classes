using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class ItalianMenu : IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Italian Menu:\n" +
                "1.Pasta\n" +
                "2.Pizza\n");
        }
    }
}
