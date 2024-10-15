using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingcartApplication.Models
{
    internal class Order
    {
        private int _orderId;
        private DateTime _date;
        private List<LineItem> _lineItems;

        public Order(int orderId, DateTime date, List<LineItem> lineItems)
        {
            _orderId = orderId;
            _date = date;
            _lineItems = lineItems;
        }

        public int OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public List<LineItem> LineItems
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }

        public double CalculateOrderPrice()
        {
            return _lineItems.Sum(item => item.CalculateLineItemCost());
        }

        public string DisplayOrderDetails()
        {
            string orderDetails = $"Order ID: {_orderId}\n" +
                                  $"Order Date: {_date.ToShortDateString()}\n" +
                                  "Line Items:\n";

            foreach (var item in _lineItems)
            {
                orderDetails += item.DisplayLineItemDetails() + "\n";
            }

            double totalOrderCost = _lineItems.Sum(item => item.CalculateLineItemCost());
            orderDetails += $"------------------------\nOrder Cost: {totalOrderCost}\n";

            return orderDetails;
        }
    }
}
