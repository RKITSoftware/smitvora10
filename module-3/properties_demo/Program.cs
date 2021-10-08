using System;

namespace properties_demo
{
    class BusinessModel
    {
        private string _businessName;
        private string _modelName;
        private double _amountRaised;
        private double _equityDiluted;
    

        public string BusinessName {
            get { return _businessName; }
            set { _businessName = value; } 
        }
        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }
        public double EquityDiluted
        {
            get { return _equityDiluted; }
            set { _equityDiluted = value; }
        }
        public double EquityOwned
        {
            get { return 100 - EquityDiluted; }

        }
        public double AmountRaised
        {
            get { return _amountRaised; }
            set { _amountRaised = value; }
        }

        
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
