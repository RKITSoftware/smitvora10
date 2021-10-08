using System;
using System.Collections.Generic;

namespace collections_generic_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> rankCricketers = new SortedList<int, string>()
            {
                {4,"Smith" },
                {3,"Williamson" },
                {1,"Kohli" }
            };

            rankCricketers.Add(2, "Root");
            foreach(KeyValuePair<int,string>kvp in rankCricketers)
            {
                Console.WriteLine("Rank is: "+kvp.Key+" Cricketer: "+kvp.Value);
            }
            //output-
            //Rank is: 1 Cricketer: Kohli
            //Rank is: 2 Cricketer: Root
            //Rank is: 3 Cricketer: Williamson
            //Rank is: 4 Cricketer: Smith
            Console.WriteLine();
            if (rankCricketers.ContainsKey(3))
            {
                rankCricketers[3] = "Sharma";
            }

            Console.WriteLine("Rank is: " + 3 + " Cricketer: " + rankCricketers[3]);
            //Rank is: 3 Cricketer: Sharma
            rankCricketers.RemoveAt(1);
            Console.WriteLine();
            foreach (KeyValuePair<int, string> kvp in rankCricketers)
            {
                Console.WriteLine("Rank is: " + kvp.Key + " Cricketer: " + kvp.Value);
            }
            //output-
            //Rank is: 1 Cricketer: Kohli
            //Rank is: 3 Cricketer: Sharma
            //Rank is: 4 Cricketer: Smith

        }
    }
}
