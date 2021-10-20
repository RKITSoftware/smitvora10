using System;
using System.IO;

namespace basic_file_operations_AppendDeleteCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathToFile = @"D://TrainingWork//smitvora10//module-4//basic_file_operations//Demo_test.txt";

            string pathToDuplicateFile = @"D://TrainingWork//smitvora10//module-4//basic_file_operations//Demo_Duplicatetest.txt";

            if(File.Exists(pathToFile))
            {
                Console.WriteLine("File exists");
                //File Exists as i made one.

                //To copy one file into another and it also creates itself at other path given
                File.Copy(pathToFile, pathToDuplicateFile);

                //Deletes the fromer file from which data is copied
                File.Delete(pathToFile);

                //To append text in the duplicated file we use StreamWriter object with AppendText method
                using(StreamWriter objWriter = File.AppendText(pathToDuplicateFile))
                {
                    objWriter.WriteLine();
                    objWriter.WriteLine("This is Appended text");
                    objWriter.WriteLine("Checked");
                }

                //To read all the text from the duplicated file we use StreamReader object
                using(StreamReader objReader = new StreamReader(pathToDuplicateFile))
                {
                    string str = "";
                    while((str=objReader.ReadLine())!=null)
                    {
                        Console.WriteLine(str);
                    }
                }
                //output - 
                //I am Smit Vora.
                //This is Demo_test.
                //This is Appended text
                //Checked
            }
            else
            {
                File.Create(pathToFile);
                Console.WriteLine("File 'Demo_test' is created");
                //File 'Demo_test' is created if file was not created.
            }
        }
    }
}
