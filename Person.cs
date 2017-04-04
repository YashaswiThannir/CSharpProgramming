using System;

namespace NonPrimitiveTypes
{
	public class Person
	{
		public string FirstName;
		public string LastName;
		//void does not return any values
		public void Introduce()
		{ 
			Console.WriteLine("My name is " + FirstName + " " + LastName );
		}
	}

}
