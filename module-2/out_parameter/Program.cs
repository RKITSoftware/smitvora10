using System;

namespace out_parameter
{
	class Matching
	{
        static public void Main()
        {

            // Creating variable
            // without assigning value
            int number;

            // Pass variable num to the method
            // using out keyword
            AddNum(out number);

            // Display the value of num
            Console.WriteLine("The sum of"
              + " the value is: {0}", number);

        }

        // Method in which out parameter is passed
        // and this method returns the value of
        // the passed parameter
        public static void AddNum(out int num)
        {
            num = 101;
            num += num;
        }
    }

}
