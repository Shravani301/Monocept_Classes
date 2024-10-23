using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryApp.Models
{
    internal class Tesla:ICar
    {
        public void Start()
        {
            Console.WriteLine("Tesla Starts");
        }
    }
}
