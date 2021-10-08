using System;
using System.Collections.Generic;

namespace collections_generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            for (int i=0;i<10;i++)
            {
                numbers.Push(i);
            }
            Console.WriteLine("No. of Elements in stack:"+numbers.Count);
            //No. of Elements in stack:10

            Console.WriteLine("Does numbers contain 9:"+numbers.Contains(9));
            //Does numbers contain 9:True

            numbers.Pop();
            //after popping it will not contain 9 as it was stack's last element

            Console.WriteLine("Does numbers contain 9:" + numbers.Contains(9));
            //Does numbers contain 9:False

            Console.WriteLine("Element at the top is:"+ numbers.Peek());
            //Element at the top is:8


        }
    }
}
