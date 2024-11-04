namespace DelegatesTypes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Action actionPtr=SayHello;
            actionPtr();

            Predicate<int> predicatePtr=CheckEvenOrOdd;
            Console.WriteLine(predicatePtr(10));

            Func<int,string,(int,string)> functPtr=GetNameAge;
            Console.WriteLine(functPtr(12, "Chotu"));
           
            int age;
            string name;
            (age, name) = functPtr(15, "Sneha");
            Console.WriteLine("Lower Case Name is:"+name);
            Console.WriteLine("Age:"+age);
            
        }
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        static bool CheckEvenOrOdd(int num)
        {
            return num % 2 == 0;
        }
        static (int, string) GetNameAge(int num, string name)
        {
            return (num+1,name.ToLower());
        }
    }

}
