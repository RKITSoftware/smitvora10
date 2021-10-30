using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace inheritance_Multilevel
    //Example showing chronological order of some days in the week
{
    class Monday
    {
        public void Display()
        {
            Console.WriteLine("Monday");
        }
    }
    class Tuesday : Monday
    {
        public void NextDay()
        {
            Console.WriteLine("Tuesday");
        }
    }
    //Multilevel Inheritance
    class Wednesday : Tuesday
    {
        public void NextToTuesday()
        {
            Console.WriteLine("Wednesday");
        }
        static void Main(string[] args)
        {
            Wednesday objWed = new Wednesday();
            objWed.Display();
            objWed.NextDay();
            objWed.NextToTuesday();
            
        }
    }
    //output -
    //Monday
    //Tuesday
    //Wednesday

}