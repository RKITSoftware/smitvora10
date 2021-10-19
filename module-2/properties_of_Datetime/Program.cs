using System;

namespace properties_of_Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateTimeProperty = new DateTime(2021, 9, 17, 7, 10, 24);
            Console.WriteLine("Day:{0}", DateTimeProperty.Day);//determines day
            Console.WriteLine("Month:{0}", DateTimeProperty.Month);//determines month
            Console.WriteLine("Year:{0}", DateTimeProperty.Year);//determines year
            Console.WriteLine("Hour:{0}", DateTimeProperty.Hour);//determines hours
            Console.WriteLine("Minute:{0}", DateTimeProperty.Minute);//determines minutes
            Console.WriteLine("Second:{0}", DateTimeProperty.Second);//determines seconds
            Console.WriteLine("Millisecond:{0}", DateTimeProperty.Millisecond);//determines milliseconds
            Console.WriteLine("Day of Week:{0}", DateTimeProperty.DayOfWeek);//determines which day of the week that particular day is
            Console.WriteLine("Day of Year: {0}", DateTimeProperty.DayOfYear);//determines which no. of day of the year that particular day is
            Console.WriteLine("Time of Day:{0}", DateTimeProperty.TimeOfDay);//determines time of the day


            int days = DateTime.DaysInMonth(2022,2);
            Console.WriteLine("Days in February of 2022 : "+days);//determines the days in 2nd month of 2022
            //Days in February of 2022 : 28

            Console.WriteLine( "Is 2022 a leap year: "+ DateTime.IsLeapYear(2022));//determines whether 2022 is leap year or not
            //Is 2022 a leap year: False

            //Use of timespan function to add time to a date
            DateTime objdate = new DateTime(2021, 12, 31);
            TimeSpan objtimespan = new TimeSpan(25, 20, 20);
            DateTime newDate = objdate.Add(objtimespan);
            Console.WriteLine("New Date is : "+newDate);//1/1/2020 1:20:20 AM
            //New Date is : 01-01-2022 01:20:20

            //Use of timespan function to subtract two dates
            DateTime objdate1 = new DateTime(2021, 12, 31);
            DateTime objdate2 = new DateTime(2021, 12, 29);
            TimeSpan objtimespan1 = objdate1.Subtract(objdate2);
            Console.WriteLine("Difference : "+objtimespan1);
            //Difference : 2.00:00:00

            //Difference with compare method
            int objdiff = DateTime.Compare(objdate1, objdate2);

            if (objdiff > 0)
                Console.WriteLine("First date is greater");
            else if (objdiff < 0)
                Console.WriteLine("Second date is greater");
            else
                Console.WriteLine("Given dates are equal");

            //output-First date is greater

            //Datetime now method gives the date of current time, here converted to the string
            Console.WriteLine("Current DateTime :" + DateTime.Now.ToString());

            //output-Current DateTime :16-10-2021 18:02:12

            //To check if the dates are equal
            bool objcompare = DateTime.Equals(objdate1, objdate2);

            if (objcompare == true)
                Console.WriteLine("Given dates are equal");
            else
                Console.WriteLine("Given dates are not equal");
            //output-Given dates are not equal




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
