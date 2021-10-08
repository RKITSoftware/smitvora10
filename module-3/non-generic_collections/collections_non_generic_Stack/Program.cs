using System;
using System.Collections;
namespace collections_non_generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack random = new Stack();
            random.Push("Smit");
            random.Push("ruthlessness");  
            random.Push(20);
            random.Push(5.12);

            foreach (var elem in random)
            {
                Console.WriteLine(elem);
            }
            //5.12
            //20
            //ruthlessness
            //Smit

            Console.WriteLine("Element at the top is: "+random.Peek());
            //Element at the top is: 5.12

            Console.WriteLine("Does it contain no. 20: "+random.Contains(20));
            //Does it contain no. 20: True

            random.Pop();
            Console.WriteLine("Does it contain double 5.12: " + random.Contains(5.12));
            //Does it contain double 5.12: False

        }
    }
}
