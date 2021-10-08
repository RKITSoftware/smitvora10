using System;
using System.Collections;
namespace collections_non_generic_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue random = new Queue();
            random.Enqueue("Smit");
            random.Enqueue("ruthlessness");
            random.Enqueue(20);
            random.Enqueue(5.12);

            foreach (var elem in random)
            {
                Console.WriteLine(elem);
            }
            //Smit
            //ruthlessness
            //20
            //5.12

            Console.WriteLine("Element at the top is: " + random.Peek());
            //Element at the top is: Smit

            Console.WriteLine("Does it contain no. 20: " + random.Contains(20));
            //Does it contain no. 20: True

            random.Dequeue();
            Console.WriteLine("Does it contain word Smit: " + random.Contains("Smit"));
            //Does it contain word Smit: False

        }
    }
}
