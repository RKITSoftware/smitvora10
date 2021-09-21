using System;

namespace properties_of_Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateTimeProperty = new DateTime(2021, 9, 17, 7, 10, 24);
            Console.WriteLine("Day:{0}", DateTimeProperty.Day);
            Console.WriteLine("Month:{0}", DateTimeProperty.Month);
            Console.WriteLine("Year:{0}", DateTimeProperty.Year);
            Console.WriteLine("Hour:{0}", DateTimeProperty.Hour);
            Console.WriteLine("Minute:{0}", DateTimeProperty.Minute);
            Console.WriteLine("Second:{0}", DateTimeProperty.Second);
            Console.WriteLine("Millisecond:{0}", DateTimeProperty.Millisecond);
            Console.WriteLine("Day of Week:{0}", DateTimeProperty.DayOfWeek);
            Console.WriteLine("Day of Year: {0}", DateTimeProperty.DayOfYear);
            Console.WriteLine("Time of Day:{0}", DateTimeProperty.TimeOfDay);







        //result - 	Day:17
        //Month: 9
        //Year: 2021
        //Hour: 7
        //Minute: 10
        //Second: 24
        //Millisecond: 0
        //Day of Week: Friday
        // Day of Year: 260
        //Time of Day: 07:10:24

        }
    }
}
