using System;
using System.Collections.Generic;

namespace various_methods_of_String_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "SmitVora";
            //Clone() used to clone a string
            string clonedOne = (String)myName.Clone();

            //Equals() method used to check if both strings are equal in value
            Console.WriteLine("Are both strings same : "+string.Equals(myName,clonedOne));
            //output - Are both strings same : True

            string hobby = " loves cricket";
            //Concate() function to concatenate 2 strings
            Console.WriteLine("Concatenated Strings : "+string.Concat(myName,hobby));
            //output - Concatenated Strings : SmitVora loves cricket

            //Contains() function to check existence of a substring
            Console.WriteLine("Does string myName contains 'Smit': "+myName.Contains("Smit"));
            //output - Does string myName contains 'Smit': True

            //Remove() method to remove characters from a specified index
            Console.WriteLine("Characters after Smit Removed and string becomes : "+myName.Remove(4));
            //output - Characters after Smit Removed and string becomes : Smit

            //Insert() method to insert in string in existing string from a certain index
            Console.WriteLine("Use of insert to get new string : "+myName.Insert(8,hobby));
            // output - Use of insert to get new string : SmitVora loves cricket

            //Replace() Method to replace a certain part of a string with new string
            Console.WriteLine("Replacing 'Vora' to 'likes finance':" +myName.Replace("Vora","loves finance"));
            // output - Replacing 'Vora' to 'likes finance':Smitloves finance

            //ToLower() method to lowercase all the letters in the string
            Console.WriteLine("Lowercase String: "+myName.ToLower());
            //output-Lowercase String: smitvora

            //ToUpper() method to uppercase all the letters in the string
            Console.WriteLine("Uppercase String: " + myName.ToUpper());
            //output-Uppercase String: SMITVORA


            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //using join method
            Console.WriteLine("using join method : "+string.Join(",",numbers));
            //output - using join method : 1,2,3,4,5,6,7,8,9

        }
    }
}
