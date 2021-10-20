using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 303, 0, 202, 101 };

            try
            {

                // Try to generate an exception
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }

            // Catch block for invalid array access
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("Exception:"+e.Message);
            }

            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Exception:"+e.Message);
            }

            // Catch block for value being out of range
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine("Exception:"+e.Message);
            }

            //output - An Exception has occurred : Attempted to divide by zero.

            // Finally block
            // Will execute irrespective of the above catch blocks
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            //output - 303 0 202 101
        }
    }
}
