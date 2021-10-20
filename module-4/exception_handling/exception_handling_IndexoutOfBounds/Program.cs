using System;

namespace exception_handling_IndexoutOfBounds
{
	using System;

	class Program 
	{
		static void Main(string[] args)
		{
			// Declare an array of max index 4
			int[] arr = {10,20,30,40,50 };

			// Display values of array elements
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			//10
			//20
			//30
			//40
			//50
			try
			{

				// Try to access invalid index of array
				Console.WriteLine(arr[10]);
				// An exception is thrown upon executing above line
				
			}
			catch (IndexOutOfRangeException e)
			{

				// The Message property of the object
				// of type IndexOutOfRangeException

				Console.WriteLine("Exception : "+ e.Message);

			}
			//output - Exception : Index was outside the bounds of the array.
		}
	}
}
