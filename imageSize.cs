using System;

namespace imageSize
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the width of the image ");
			var w = Console.ReadLine();
			double width = Convert.ToDouble(w);

			Console.WriteLine("Enter the height of the image ");
			var h = Console.ReadLine();
			double height = Convert.ToDouble(h);
		
			if (width > height)
			{
				Console.WriteLine("It is a landscape");
			}
			else 
			{ 
				Console.WriteLine("It is a potrait");
			}


		}
	}
}
