using ShoppingcartApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingcartApplication.Services
{
    internal class ProductService
    {
        private List<Product> _products = new List<Product>();

        public ProductService()
        {
            InitializeStaticData();
        }

        public Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }

        private void InitializeStaticData()
        {
            _products.Add(new Product(101, "Laptop", 1000, 10));
            _products.Add(new Product(102, "Smartphone", 600, 15));
            _products.Add(new Product(103, "Tablet", 400, 5));
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
