using ShoppingcartApplication.Models;
using ShoppingcartApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingcartApplication.Controller
{
    internal class CustomerController
    {
        private readonly CustomerService _customerService = new CustomerService();

        public void AddNewCustomer(Customer customer)
        {
            _customerService.AddCustomer(customer);
        }

        public Customer GetCustomerById(int customerId)
        {
            return _customerService.GetCustomerById(customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }
    }
}
