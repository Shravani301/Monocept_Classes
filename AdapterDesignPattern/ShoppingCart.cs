using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class ShoppingCart
    {
        List<IItems> ShoppingList;
        public ShoppingCart()
        {
            ShoppingList = new List<IItems>();
        }
        public void AddItems(IItems item)
        {
            ShoppingList.Add(item);
        }
        public List<IItems> GetCartItems()
        {
            return ShoppingList;
        }
        public double GetCartPrice()
        {
            double total = 0;
            foreach (var item in ShoppingList)
            {
                total += item.GetPrice();
            }
            return total;
        }

    }
}
