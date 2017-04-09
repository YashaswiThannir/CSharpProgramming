using System;

namespace maxNumber
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the value of number 1");
			var num1 = Console.ReadLine();
			int number1 = Convert.ToInt32(num1);

			Console.WriteLine("The value of number 1 is: "+number1);
	

			Console.WriteLine("Enter the value of number 2");
			var num2 = Console.ReadLine();
			int number2 = Convert.ToInt32(num2);
			Console.WriteLine("The value of number 2 is: " +number2);

			if (number1 > number2)
			{
				Console.WriteLine(number1 + " is greater");
			}
			else
			{ 
				Console.WriteLine(number2 + " is greater");
			}
		}
	}
}
