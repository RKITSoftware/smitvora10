using System;
using System.Collections.Generic;

namespace collection_generic_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var cricketers = new Dictionary<string,string>()
            {
                {"India","Kohli,Sharma,Rahul" },
                {"Australia","Smith,Maxwell,Warner" }
            };
            cricketers.Add("England", "Root,Stokes,Anderson");

            foreach (KeyValuePair<string,string> kvp in cricketers)
            {
                Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value);
            }

            //Key: India Value: Kohli,Sharma,Rahul
            //Key: Australia Value: Smith,Maxwell,Warner
            //Key: England Value: Root,Stokes,Anderson

            Console.WriteLine();
            if (cricketers.ContainsKey("Australia"))
            {
                cricketers.Remove("Australia");
            }
            foreach (KeyValuePair<string, string> kvp in cricketers)
            {
                Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value);
            }
            //Key: India Value: Kohli,Sharma,Rahul
            //Key: Australia Value: Smith,Maxwell,Warner
        }
    }
}
