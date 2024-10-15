using System;

namespace ShoppingcartApplication.Models
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private double _discountPercent;

        public Product(int id, string name, double price, double discountPercent)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = discountPercent;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double DiscountPercent
        {
            get { return _discountPercent; }
            set { _discountPercent = value; }
        }

        public double CalculateDiscountedPrice()
        {
            double discountAmount = (_price * _discountPercent) / 100;
            return _price - discountAmount;
        }

        public string DisplayProductDetails()
        {
            return $"Product ID: {_id}\n" +
                   $"Name: {_name}\n" +
                   $"Price: {_price}\n" +
                   $"Discount Percent: {_discountPercent}%\n" +
                   $"Discounted Price: {CalculateDiscountedPrice()}\n";
        }
    }
}
