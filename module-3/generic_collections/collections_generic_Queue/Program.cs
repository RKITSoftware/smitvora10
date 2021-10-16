using System;
using System.Collections.Generic;
namespace collections_generic_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            for (int i = 1; i < 10; i++)
            {
                numbers.Enqueue(i);

            }

            Console.WriteLine(string.Join("",numbers));
            //123456789

            Console.WriteLine("No. of Elements in queue:" + numbers.Count);
            //No. of Elements in queue:9

            Console.WriteLine("Does numbers contain 1:" + numbers.Contains(1));
            //Does numbers contain 1:True

            
            //after popping it will not contain 1 as it was queue's last element

            Console.WriteLine("Element popped:" + numbers.Dequeue());
            //Element popped:1

            Console.WriteLine("Does numbers contain 1:" + numbers.Contains(1));
            //Does numbers contain 1:False

            Console.WriteLine("Element at the top is:" + numbers.Peek());
            //Element at the top is:2


        }
    }
}
