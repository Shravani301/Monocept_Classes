using System;

namespace ShoppingcartApplication.Models
{
    internal class LineItem
    {
        private int _id;
        private int _quantity;
        private Product _product;

        public LineItem(int id, int quantity, Product product)
        {
            _id = id;
            _quantity = quantity;
            _product = product;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public double CalculateLineItemCost()
        {
            double discountedPrice = _product.Price * (1 - _product.DiscountPercent / 100);
            return discountedPrice * _quantity;
        }

        public string DisplayLineItemDetails()
        {
            double discountedPrice = _product.Price * (1 - _product.DiscountPercent / 100);
            double totalLineItemCost = CalculateLineItemCost();

            return $"{_id}\t{_product.Id}\t{_product.Name}\t{_quantity}\t{_product.Price}\t" +
                   $"{_product.DiscountPercent}%\t{discountedPrice}\t{totalLineItemCost}";
        }
    }
}
