using System;

namespace named_parameter
{
	public class Operation
	{
		// operating contain three parameters
		public static void operating(int a, int b, int c)
		{
			int result = a + b * c;
			Console.WriteLine("Final result is: " + result);
		}

		// Main Method
		static public void Main()
		{
			// calling the static method with named
			// parameters without any order
			operating(b: 6, a: 2, c: -2);

		}
	}
	//result - Final result is: -10

}
