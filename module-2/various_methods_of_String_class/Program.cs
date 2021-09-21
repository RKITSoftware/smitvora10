using System;

namespace various_methods_of_String_class
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "world";
            string c = (String)a.Clone();
            string d = string.Concat(a, b);
            string e = string.Copy(d);
            string f = a.Remove(2);
            string g = b.Replace("wor","smit");
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);


            //result – hello
            //helloworld
            //helloworld
            //he
            //smitld

        }
    }
}
