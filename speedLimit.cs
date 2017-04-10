using System;

namespace speedLimit
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("Please enter the speed limit in this area");
			var sl = Console.ReadLine();
			int spLim = Convert.ToInt32(sl);
			Console.WriteLine("What is the speed of the car?");
			var speed = Console.ReadLine();
			int vehicleSp = Convert.ToInt32(speed);
			if (vehicleSp <= spLim)
			{
				Console.WriteLine("OK!");
			}
			else 
			{
				
				int demerit = (vehicleSp - spLim)/5;
				Console.WriteLine("Demerit points: "+demerit);
				if (demerit >= 12)
				{ 
					Console.WriteLine("License Suspended");
				}
			

			}

		}
	}
}
