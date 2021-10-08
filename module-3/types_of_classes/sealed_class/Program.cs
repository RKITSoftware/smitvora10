using System;

namespace sealed_class
{
    //Sealed class for area of the circle
    sealed class AreaCircle
    {
        public double AreaOfCircle(int r)
        {
            return Math.PI * Math.Pow(r,2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AreaCircle areaCircle = new AreaCircle();
            double ans=areaCircle.AreaOfCircle(7);
            Console.WriteLine("Area of the Circle : {0}", ans);
        }
        //output-
        //Area of the Circle : 153.93804002589985
        //if sealed class is inherited to any other class it produces a compile time error
    }
}
