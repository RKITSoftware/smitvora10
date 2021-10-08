using System;

namespace parameterized_contructor
{
    class Business
    {
        string model;
        double sales;
        //parameterized constructor
        Business(string model,double sales)
        {
            this.model = model;
            this.sales = sales;
            Console.WriteLine("Constructor is called");
        }
        static void Main(string[] args)
        {
            //object created which points straight to constructor
            Business business = new Business("DTC",3846353.5);
            Console.WriteLine("Business model is: " +business.model);
            Console.WriteLine("Sales are: " +business.sales);
        }
        //Constructor is called
        //Business model is: DTC
        //Sales are: 3846353.5
    }
}
