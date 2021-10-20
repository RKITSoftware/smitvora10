using System;
using System.IO;

namespace basic_file_operations_StreamReader
{
    class Program
    {
        public void DataRead()
        {
            //This will read from the file given in the location
            StreamReader objReader = new StreamReader("D://TrainingWork//smitvora10//module-4//basic_file_operations//Demo_StreamWriter.txt");

            Console.WriteLine("Text in the file:");
            //this takes user input in string variable
            string str = objReader.ReadLine();
            //till we get lines of text this keeps on executing 
            while(str!=null)
            {
                //prints the text we get in the console
                Console.WriteLine(str);
                str = objReader.ReadLine();
            }
            //stream is closed
            objReader.Close();
        }
        static void Main(string[] args)
        {
            Program objProgram = new Program();
            objProgram.DataRead();
           //output - I am Smit Vora 
        }
    }
}

