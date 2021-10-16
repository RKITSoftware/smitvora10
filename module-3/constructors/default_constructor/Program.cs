using System;

namespace default_constructor
{
    class Business
    {
        string model;
        //constructor
        Business()
        {
            model = "DTC";
            Console.WriteLine("Constructor is called");
        }
        static void Main(string[] args)
        {
            //object created points straight to constructor
            Business business = new Business();
            Console.WriteLine("Business model is:"+business.model);
        }
	//output-
        //Constructor is called
        //Business model is:DTC
    }
}
