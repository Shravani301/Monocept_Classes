using ShoppingcartApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingcartApplication.Services
{
    internal class OrderService
    {
        public double CalculateOrderTotal(Order order)
        {
            return order.LineItems.Sum(lineItem => lineItem.CalculateLineItemCost());
        }

        public void AddLineItem(Order order, LineItem lineItem)
        {
            order.LineItems.Add(lineItem);
        }

        public string DisplayOrder(Order order)
        {
            return order.DisplayOrderDetails();
        }
    }

}
