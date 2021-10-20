using System;
using System.IO;

namespace basic_file_operations_StreamWriter
{
    class Program
    {
        public void Data()
        {
            //This will write in the file given in the location
            StreamWriter objWriter = new StreamWriter("D://TrainingWork//smitvora10//module-4//basic_file_operations//Demo_StreamWriter.txt");

            Console.WriteLine("Enter text to write in demo file:");
            //this takes user input in string variable
            string str = Console.ReadLine();
            //Then we write the text to take in the buffer
            objWriter.WriteLine(str);
            //writes the stream into file and clears buffer
            objWriter.Flush();
            //closes the stream and stream object
            objWriter.Close();
        }
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.Data();

        }
    }
}
