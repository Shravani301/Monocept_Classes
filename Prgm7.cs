using System;
class Prgm7
{
	public static void Main(String [] args)
	{
		int n,count=0;
		Console.WriteLine("Enter a number to check whether it is prime or not:");
		n=Convert.ToInt32(Console.ReadLine());
		for(int i=1;i<=n;i++)
		{
			if(n%i==0)
			{
				count++;
			}

		}
if(count>2)
	Console.WriteLine("Given number is not Prime");
else
	Console.WriteLine("Given number is Prime");
		
	}
}