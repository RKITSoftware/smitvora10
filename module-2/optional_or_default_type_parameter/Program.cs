using System;

namespace optional_or_default_type_parameter
{
	public class Operation
	{
		// operating contain three parameters
		public static void operating(int a, int b, int c = 2)
		{
			int result = a + b * c;
			Console.WriteLine("Final result is: " + result);
		}

		// Main Method
		static public void Main()
		{
			// calling the static method with named
			// parameters without any order
			operating(6, 2);

		}
	}
	//result - Final result is: 10
	//As default value of c is taken as 2

}
