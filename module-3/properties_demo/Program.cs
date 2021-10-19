using System;

namespace properties_demo
{
    class BusinessModel
    {    
        public string BusinessName { get; set; }
        public string ModelName { get; set; }

        public double EquityDiluted{ get; set;  }
        public double EquityOwned
        {
            get { return 100 - EquityDiluted; }

        }
        public double AmountRaised { get; set; }


        public override string ToString()
        {
            return "BusinessName = " + BusinessName  + "\nModel = " + ModelName  + "\nAmount Raised(Rs.) = " + AmountRaised +
                "\nEquity Diluted (%)= " + EquityDiluted  + "\nEquity Owned (%)= " + EquityOwned;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BusinessModel bm = new BusinessModel();
            bm.BusinessName = "VOR Corp.";
            bm.ModelName = "Direct To Consumer";
            bm.EquityDiluted = 5.91;
            bm.AmountRaised = 5000000.00;
            Console.WriteLine("Business Model is {0}:", bm);

            //output-
            //Business Model is BusinessName = VOR Corp.
            //Model = Direct To Consumer
            //Amount Raised(Rs.) = 5000000
            //Equity Diluted(%)= 5.91
            //Equity Owned(%)= 94.09:
        }
    }
}
