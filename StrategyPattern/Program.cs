namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mall mall = new Mall(new GPay());
            Print(mall);
            Mall mall1 = new Mall(new Paytm());
            Print(mall1);
            Mall mall2 = new Mall(new CC());
            Print(mall2);


        }
        static void Print(Mall mall)
        {
            Console.WriteLine(mall.MakePayment());
        }
    }
}
