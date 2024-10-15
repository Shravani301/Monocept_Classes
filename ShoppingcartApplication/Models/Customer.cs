using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingcartApplication.Models
{
    internal class Customer
    {
        int customerId;
        string customerName;

        List<Order> orders;
        public Customer(int id, string name) {
            customerId = id;
            customerName = name;
            orders = new List<Order>();
        }
        public int Id
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string Name
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public List<Order> Orders
        {
            get { return orders; }
            set { orders = Orders; }
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public string DisplayCustomerInfo()
        {
            string customerInfo = $"Customer ID: {customerId}\n" +
                $"Name: {customerName}\n" +
                $"Orders Count:{orders.Count}\n" +
                $"Orders:\n";

            foreach (var order in orders)
            {
                customerInfo += order.DisplayOrderDetails() + "\n";
            }

            return customerInfo;
        }

    }
}
