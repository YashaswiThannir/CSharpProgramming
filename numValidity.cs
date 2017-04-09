using System;

namespace NumberValidity
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number between 1  to 10");
			var n = Console.ReadLine();
			int num = Convert.ToInt32(n);
			if (num >= 1 && num <= 10)
			{
				Console.WriteLine("valid number");
			}
			else
			{
				Console.WriteLine("invalid number");
			}
		}
	}
}
