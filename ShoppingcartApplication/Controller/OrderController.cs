using ShoppingcartApplication.Models;
using ShoppingcartApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingcartApplication.Controller
{
    internal class OrderController
    {
        private readonly OrderService _orderService = new OrderService();

        public void AddLineItem(Order order, LineItem lineItem)
        {
            _orderService.AddLineItem(order, lineItem);
        }

        public double GetOrderTotal(Order order)
        {
            return _orderService.CalculateOrderTotal(order);
        }

        public string DisplayOrder(Order order)
        {
            return _orderService.DisplayOrder(order);
        }
    }
}
