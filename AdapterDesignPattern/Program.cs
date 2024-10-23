namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItems(new Biscuit("GoodDay", 10));
            cart.AddItems(new Chocolate("KitKat", 40));
            cart.AddItems(new HatAdapter(new Hat("Ho1", "Elegant Fedora", 100, 5)));

            var cartItems = cart.GetCartItems();
            Console.WriteLine("Cart Items are:");

            foreach (var item in cartItems)
            {
                Console.WriteLine($"{item.GetName()} - Price: {item.GetPrice()}");
            }

            Console.WriteLine($"Total Cart Price: {cart.GetCartPrice()}");

        }
    }
}
