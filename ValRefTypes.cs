using System;

namespace ValRefTypes
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//value type example
			var a = 10;
			var b = a;
			//value of a will be independent of b, in memory a will be 10 at a location and a will be 10 at a location 
			b++;
			Console.WriteLine(string.Format(" a: {0}, b: {1}", a,b));

			//Reference type example
			var array1 = new int[3] { 1, 2, 3 };
			var array2 = array1;
			array2[0] = 0;
			Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));


		}
	}
}
