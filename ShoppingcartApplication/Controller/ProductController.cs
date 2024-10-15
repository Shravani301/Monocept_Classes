using ShoppingcartApplication.Models;
using ShoppingcartApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingcartApplication.Controller
{
    internal class ProductController
    {
        private readonly ProductService _productService = new ProductService();

        public Product GetProductById(int productId)
        {
            return _productService.GetProductById(productId);
        }

        public List<Product> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }
    }
}
