using RectangleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle()
            {
                Length = 10,
                Breadth=10,
                Color="Blue"
            };

            Console.WriteLine(small.PrintDetails("Small"));

            /*small.SetLength(20);
            small.SetBreadth(20);
            small.SetColor("Blue");*/

            small.Length = 20;
            small.Breadth = 20;
            small.Color = "Green";
            
            Console.WriteLine(small.PrintDetails("Small"));           
            Console.WriteLine("Accessing Individual elements: "+small.Color);
            Console.WriteLine(small.Length);
            

        }
       
        
    }
}
