using System;

namespace inheritance_Hierarchical
{
    abstract class DayOfWeek
    {
        public abstract void Day();
    }
    class Monday : DayOfWeek
    {
        public override void Day()
        {
            Console.WriteLine("Day is Monday");
        }
    }
    class Tuesday : DayOfWeek
    {
        public override void Day()
        {
            Console.WriteLine("Day is Tuesday");
        }
    }
    class Wednesday : DayOfWeek
    {
        public override void Day()
        {
            Console.WriteLine("Day is Wednesday");
        }
    }
    //Multilevel Inheritance
    class Program
    {
        static void Main(string[] args)
        {
            Monday objMonday = new Monday();
            Tuesday objTuesday = new Tuesday();
            Wednesday objWednesday = new Wednesday();

            objMonday.Day();
            objTuesday.Day();
            objWednesday.Day();


        }
    }
    //output -
    //Day is Monday
    //Day is Tuesday
    //Day is Wednesday

}
