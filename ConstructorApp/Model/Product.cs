using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp.Model
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductCost { get; set; }
        static double DEFAULT_COST=10000;


        public Product(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
            ProductCost = DEFAULT_COST;
        }
        public Product(int productId, string productName, int productCost):this(productId, productName) 
        {
            ProductCost = (ProductCost < DEFAULT_COST)? DEFAULT_COST :productCost;
        }   

        public void PrintProduct() {
            Console.WriteLine("Prdouct ID is: "+ProductId);
            Console.WriteLine($"Product Name is: {ProductName}");
            Console.WriteLine("Product Cost is {0}",ProductCost);
            Console.WriteLine();
        }
    }
}
