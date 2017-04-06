using System;

namespace CSharpFundamentals
{
	public enum ShippingMethod
	{
		RegularAirMail = 1,
		RegisteredAirMail = 2,
		Express = 3
	}

	class MainClass
	{
		public static void Main(string[] args)
		{
			var method = ShippingMethod.Express;
			//casting int as datatype will display 3, without casting this will output Express
			Console.WriteLine((int)method);

			var methodId = 3;
			Console.WriteLine((ShippingMethod)methodId);
			Console.WriteLine(method.ToString());

			var methodName = "Express";
			//converting parse string to enum or enumeration
			var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
			Console.WriteLine(shippingMethod); 


		}
	}
}
