using System;
class Prgm8
{
	public static void Main(String [] args)
	{
		int n, res=0, num;
		Console.WriteLine("Enter number to check whether it is Armstrong or not:");
		n=Convert.ToInt32(Console.ReadLine());
		num=n;
		int digits=0;
		while(n!=0)
		{
			n=n/10;
			digits++;
		}
		n=num;
		while(n!=0)
		{
			int rem=n%10;
			n=n/10;
			res=(int)(Math.Pow(rem,digits))+res;			
		}
		if(res==num)
			Console.WriteLine("Given number is an arm strong");
		else
			Console.WriteLine("Given number is not an armstrong");
	}
}