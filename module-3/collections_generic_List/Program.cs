using System;
    
using System.Collections.Generic;

namespace collections_generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int[] array = { 1, 2, 3, 4, 5 };
            int[] newarray = { 6, 7, 8 };
            list.AddRange(array);
            list.Remove(5);           
            foreach (int integer in list)
            {
                Console.Write(integer + ",");
            }
            //output - 1,2,3,4,

            Console.WriteLine();
            Console.WriteLine("Does arraylist contains 4:" + list.Contains(4));
            //Does arraylist contains 4:True
            Console.WriteLine();
            list.InsertRange(4, newarray);
            foreach (int integer in list)
            {
                Console.Write(integer + ",");
            }
            //output - 1,2,3,4,6,7,8,
        }
    }
}
