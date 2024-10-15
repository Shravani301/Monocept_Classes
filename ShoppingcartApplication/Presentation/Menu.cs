using ShoppingcartApplication.Controller;
using ShoppingcartApplication.Models;
using System;
using System.Collections.Generic;

namespace ShoppingcartApplication.Presentation
{
    public class Menu
    {
        private readonly CustomerController _customerController = new CustomerController();
        private readonly ProductController _productController = new ProductController();
        private readonly OrderController _orderController = new OrderController();

        public void ShowMenu()
        {
            string option;

            do
            {
                DisplayMenuOptions();
                option = Console.ReadLine();
                ExecuteOption(option);
            } while (option != "4");
        }

        private void DisplayMenuOptions()
        {
            Console.WriteLine("\n*** Shopping Cart Menu ***");
            Console.WriteLine("1. Display All Customers");
            Console.WriteLine("2. Add New Customer");
            Console.WriteLine("3. Place an Order");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
        }

        private void ExecuteOption(string option)
        {
            if (option == "1") DisplayAllCustomers();
            else if (option == "2") AddNewCustomer();
            else if (option == "3") PlaceOrder();
            else if (option == "4") ExitProgram();
            else InvalidOption();
        }

        private void DisplayAllCustomers()
        {
            var customers = _customerController.GetAllCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.DisplayCustomerInfo());
            }
        }

        private void AddNewCustomer()
        {
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Customer newCustomer = new Customer(customerId, customerName);
            _customerController.AddNewCustomer(newCustomer);

            Console.WriteLine("Customer added successfully!");
        }

        private void PlaceOrder()
        {
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Customer customer = _customerController.GetCustomerById(customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            Console.Write("Enter Order ID: ");
            int orderId = int.Parse(Console.ReadLine());

            List<LineItem> lineItems = new List<LineItem>();
            string addMoreItems = "";  // Initialize the variable

            do
            {
                Console.WriteLine("Available Products:");
                var products = _productController.GetAllProducts();
                foreach (var product in products)
                {
                    Console.WriteLine(product.DisplayProductDetails());
                }

                Console.Write("Enter Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Product productToAdd = _productController.GetProductById(productId);
                if (productToAdd == null)
                {
                    Console.WriteLine("Product not found.");
                    continue;
                }

                Console.Write("Enter Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                LineItem lineItem = new LineItem(lineItems.Count + 1, quantity, productToAdd);
                lineItems.Add(lineItem);

                Console.Write("Do you want to add another item? (yes/no): ");
                addMoreItems = Console.ReadLine().ToLower();
            } while (addMoreItems == "yes");

            Order newOrder = new Order(orderId, DateTime.Now, lineItems);
            customer.AddOrder(newOrder);

            Console.WriteLine("Order placed successfully!");
        }

        private void ExitProgram()
        {
            Console.WriteLine("Exiting the program...");
        }

        private void InvalidOption()
        {
            Console.WriteLine("Invalid option, please try again.");
        }
    }
}
