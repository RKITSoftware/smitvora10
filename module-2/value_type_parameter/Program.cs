using System;

namespace value_type_parameter
{
	public class Mul
	{
		static public void Main()
		{   // The value of the parameter
			// is already assigned
			int a = 4;
			int b = 5;
			int res =  multiply(a, b);
			Console.WriteLine(res);
		}

		public static int multiply(int n1, int n2)
		{
			return n1 * n2;
		}
	}

}
