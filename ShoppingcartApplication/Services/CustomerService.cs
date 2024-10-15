using ShoppingcartApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingcartApplication.Services
{
    internal class CustomerService
    {
        private List<Customer> _customers = new List<Customer>();

        public CustomerService()
        {
            InitializeStaticData(); // Load static data when the service is initialized
        }

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customers.FirstOrDefault(c => c.Id == customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customers;
        }

        private void InitializeStaticData()
        {
            var customer1 = new Customer(1, "Shravani");
            var customer2 = new Customer(2, "Shirisha");

            var product1 = new Product(101, "Laptop", 1000, 10);
            var product2 = new Product(102, "Smartphone", 600, 15);

            var lineItem1 = new LineItem(1, 2, product1);
            var lineItem2 = new LineItem(2, 1, product2);

            var order1 = new Order(1, DateTime.Now, new List<LineItem> { lineItem1, lineItem2 });
            customer1.AddOrder(order1);

            var lineItem3 = new LineItem(3, 3, product1);
            var order2 = new Order(2, DateTime.Now.AddDays(-2), new List<LineItem> { lineItem3 });
            customer2.AddOrder(order2);

            _customers.Add(customer1);
            _customers.Add(customer2);
        }
    }
}
