using System;
using System.Collections;

namespace collections_non_generic_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList()
            {
                'I',4.50f,null
            };
            int[] array = {1,2,3,4,5};
            int[] newarray = {6,7,8};
            arrayList.AddRange(array);
            arrayList.Add("Sequence");
            arrayList.Add("Edited");
            arrayList.Remove(5);
            arrayList.Remove(null);
            foreach (object obj in arrayList)
            {
                Console.Write(obj+",");
            }
            //output - I,4.5,1,2,3,4,Sequence,Edited,

            Console.WriteLine();
            Console.WriteLine("Does arraylist contains sequence:"+arrayList.Contains("Sequence"));
            //Does arraylist contains sequence:True

            arrayList.InsertRange(6, newarray);
            foreach (object obj in arrayList)
            {
                Console.Write(obj + ",");
            }
            //I,4.5,1,2,3,4,6,7,8,Sequence,Edited,
        }
    }
}
