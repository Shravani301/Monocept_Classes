using System;
class Prgm4
{
	public static void Main(String []args)
	{
		int num,res=1;
		Console.WriteLine("Enter number");
		num=Convert.ToInt32(Console.ReadLine());
		if(num==1)
		{
			Console.WriteLine("factorial of 1 is: 1");
		}
		else{
		for(int i=num;i>0;i--)
		{
			res=res*i;
		}
		Console.WriteLine("factorial of a given number is: "+res);
		}
	
	}
}