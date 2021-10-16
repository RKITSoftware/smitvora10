using System;

namespace static_class
{

    // Creating static class
    // Using static keyword
    static class AccountDetails
    {

        // Static data members of AccountDetails
        public static int Act_no = 1905;
        public static string F_name = "Smit";
        public static string L_name = "Vora";
        public static double amount = 55000.00;


        // Static method of AccountDetails
        public static void details()
        {
            Console.WriteLine("The details of Account is-");
        }
    }

    
    public class AccountDetails_Demo
    {

        // Main Method
        static public void Main()
        {

            // Calling static method of static class
            AccountDetails.details();

            // Accessing the static data members of static class as it cannot be inherited or instantiated
            Console.WriteLine("Account No. : {0} ", AccountDetails.Act_no);
            Console.WriteLine("Account Holder's First name : {0} ", AccountDetails.F_name);
            Console.WriteLine("Account Holder's Last name : {0} ", AccountDetails.L_name);
            Console.WriteLine("Amount in the Deposit : {0} ",
                                                  AccountDetails.amount);
        }
        //output-
        //The details of Account is-
        //Account No. : 1905
        //Account Holder's First name : Smit
        //Account Holder's Last name : Vora
        //Amount in the Deposit : 55000
    }
}
