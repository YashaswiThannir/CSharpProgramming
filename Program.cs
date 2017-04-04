using System;
using NonPrimitiveTypes.Math;

namespace NonPrimitiveTypes
{
	
	class Program
	{
		static void Main(string[] args)
		{
			//creating object for the class Person
			var yashu = new Person();
			yashu.FirstName = "Yashu";
			yashu.LastName = "Thannir";
			yashu.Introduce();
			Calculator c = new Calculator();
			var result = c.calc(2, 4);
			Console.WriteLine(result);
		}
	}

}
