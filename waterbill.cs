using System;
class Prgm5
{
	public static void Main(String []args)
	{
		const int METER_CHARGED=75;
		int units,charge,waterBill;

		Console.WriteLine("Enter Number of Units Consumed");
		units=Convert.ToInt32(Console.ReadLine());

		if(units<=100)
		{
			charge=units*5;
		}
		else if(units<=250)
		{
			charge=units*10;
		}
		else
		{
			charge=units*20;
		}
		waterBill=charge + METER_CHARGED;
		Console.WriteLine(waterBill);
	}
}