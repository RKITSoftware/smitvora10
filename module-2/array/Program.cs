using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };//creating and initializing array  
            int sum = 0;
            //traversing array  
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("Total sum = {0}", sum);

        }
    }
}
