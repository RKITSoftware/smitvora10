using System;

namespace foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = {"mango","guava","banana","apple"};
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
