using System;
using System.Collections;

namespace collections_non_generic_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var cricketers = new Hashtable()
            {
                {"India","Kohli,Sharma,Rahul" },
                {"Australia","Smith,Maxwell,Warner" }                
            };
            cricketers.Add("England", "Root,Stokes,Anderson");

            foreach(DictionaryEntry de in cricketers)
            {
                Console.WriteLine("Key: " + de.Key + " Value: " + de.Value);
            }

            //Key: India Value: Kohli,Sharma,Rahul
            //Key: Australia Value: Smith,Maxwell,Warner
            //Key: England Value: Root,Stokes,Anderson

            Console.WriteLine();
            if(cricketers.ContainsKey("Australia"))
            {
                cricketers.Remove("Australia");
            }
            foreach (DictionaryEntry de in cricketers)
            {
                Console.WriteLine("Key: " + de.Key + " Value: " + de.Value);
            }
            //Key: India Value: Kohli,Sharma,Rahul
            //Key: Australia Value: Smith,Maxwell,Warner
        }
    }
}
