using System;

namespace interfaces
{
    interface IStartUp
    {
        void Status();
        void Funding();
        void Sector();
        void Valuation();
    }
    interface ICompetition
    {
        void CompetitionName();
        void Origin();
    }
    class Ola : IStartUp,ICompetition
    {
        public void Projections()
        {
            
            Console.WriteLine("Projections for next year are: $4.9B");
        }
        public void Funding()
        {
            Console.WriteLine("Received Funding : $3.8B");
        }

        public void Sector()
        {
            Console.WriteLine("Sector : Ride hailing");
        }

        public void Status()
        {
            Console.WriteLine("Status : Functional");
        }

        public void Valuation()
        {
            Console.WriteLine("Valuation : $6.7B");
        }

        public void CompetitionName()
        {
            Console.WriteLine("CompetitionName : Uber");
        }

        public void Origin()
        {
            Console.WriteLine("Originated in : USA");
        }
    }
    class Ebay : IStartUp
    {
        public void Funding()
        {
            Console.WriteLine("Funding : $0.0");
        }

        public void Sector()
        {
            Console.WriteLine("Sector : Online Shopping");
        }

        public void Status()
        {
            Console.WriteLine("Status : Defunct");
        }

        public void Valuation()
        {
            Console.WriteLine("Valuation : $0.0");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola stats: ");
            Ola objOla = new Ola();            
            objOla.Projections();
            objOla.Valuation();
            objOla.Funding();
            objOla.Sector();
            objOla.Status();
            objOla.CompetitionName();
            objOla.Origin();

        //output-
        //Ola stats:
        //Projections for next year are: $4.9B
        //Valuation : $6.7B
        //Received Funding : $3.8B
        //Sector : Ride hailing
        //Status : Functional
        //CompetitionName: Uber
        //Originated in : USA

            Console.WriteLine("Ebay stats: ");
            Ebay objEbay = new Ebay();
            objEbay.Valuation();
            objEbay.Funding();
            objEbay.Sector();
            objEbay.Status();
            //output - 
            //Ebay stats:
            //Valuation: $0.0
            //Funding: $0.0
            //Sector: Online Shopping
            //Status: Defunct
        }
    }
}
