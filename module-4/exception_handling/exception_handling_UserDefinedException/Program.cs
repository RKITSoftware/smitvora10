using System;

namespace exception_handling_UserDefinedException

{
    //User-Defined ApplicationException class
    class DebtExceeded:ApplicationException
    {
        public DebtExceeded()
        {
            Console.WriteLine("Debt has exceede the limit");
        }
    }

    class Program
    {
        
        public void checkDebt(int debt)
        {
            //Condition for the exception to be thrown
            if(debt>1000000)
            {
                throw new DebtExceeded();
                //Debt has exceede the limit
            }
        }

        static void Main(string[] args)
        {
            Program objProgram = new Program();
            //calling method in try block and if it doen't execute than catch block executes
            try
            {
                objProgram.checkDebt(50000000);
            }
            //Exception message in catch block
            catch(DebtExceeded e)
            {
                Console.WriteLine("Exception:"+e.Message);
            }
            //Exception:Error in the application.
        }
    }
}
