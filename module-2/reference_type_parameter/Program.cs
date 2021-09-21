using System;

namespace reference_type_parameter
{
	class Matching
	{
		public static void Main()
		{   // Assigning value
			string val = "Smit Vora";
	        // Pass as a reference parameter
			CompareValue(ref val);

			Console.WriteLine(val);
		}

		static void CompareValue(ref string val1)
		{
			// Compare the value
			if (val1 == "Smit Vora")
			{
				Console.WriteLine("Matched!");
			}

			// Assigning new value
			val1 = "Not Me";
		}
	}
	// result – Matched!
	//			Not Me
// as change made in method reflected on the variable in the main method through reference.

}
