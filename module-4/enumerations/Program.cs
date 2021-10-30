using System;

namespace enumerations
{
    public enum enmStartUp
    {
        SelfCapital,
        SeedRound,
        VentureCapital,
        SeriesA,
        SeriesC=6,
        SeriesB=5
        
    }
    class Program
    {
        static void Main(string[] args)
        {
           //here we obtain value and integer from enum at the same time and it shows result in sequence of integers 
           foreach(var name in Enum.GetNames(typeof(StartUp)))
            {
                Console.WriteLine(name + '-' +(int)Enum.Parse(typeof(StartUp),name));
            }
            //SelfCapital - 0
            //SeedRound - 1
            //VentureCapital - 2
            //SeriesA - 3
            //SeriesB - 5
            //SeriesC - 6
        }
    }
}
