using DotLiquid.Tags;
using System;

namespace abstract_class
{
    //abstract class operations
    abstract class Operations
    {
        public abstract void Calculate(int number1, int number2);
    }
    //subclass Addition of operations
    class Addition : Operations
    {
        public override void Calculate(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine("Sum is:{0}", sum);
        }
    }
    //subclass Subtraction of operations
    class Subtraction : Operations
    {
        public override void Calculate(int number1, int number2)
        {
            int difference = number1 - number2;
            Console.WriteLine("Difference is:{0}", difference);
        }
    }
    //subclass Area of operations
    class Area : Operations
    {
        public override void Calculate(int number1, int number2)
        {
            int areaOfSquare = number1 * number2;
            Console.WriteLine("Area Of Square is:{0}", areaOfSquare);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            add.Calculate(4, 5);
            

            Subtraction sub = new Subtraction();
            sub.Calculate(7,2);
            

            Area area = new Area();
            area.Calculate(7,8);
        }
        //Sum is:9
        //Difference is:5
        //Area Of Square is:56
    }
}
