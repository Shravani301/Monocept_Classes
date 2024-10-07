using System;
class Prgm2
{
	public static void Main(String []args)
	{
		int num1,num2,res;
		Console.WriteLine("Enter first number");
		num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number");
		num2=Convert.ToInt32(Console.ReadLine());
		res=num1+num2;
		Console.WriteLine("sum of 2 numbers is:"+res);	
	}
}