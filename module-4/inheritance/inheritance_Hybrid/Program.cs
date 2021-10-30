using System;

namespace inheritance_Hybrid
{
    //Interface ICotton and IPolyester containing methods of requirement to show their requirement in respective apparel
    interface ICotton
    {
        public void CottonRequirement();

    }
    interface IPolyester
    {
        public void PolyesterRequirement();
                   
        
    }

    //Shirt and hoodie class showing Hybrid inheritance
    class Shirt : ICotton, IPolyester
    {
        public void CottonRequirement()
        {
            Console.WriteLine("Cotton can be required to build Shirt");
        }

        public void PolyesterRequirement()
        {
            Console.WriteLine("Polyester can be required to build Shirt");
        }
    }
    class Hoodie : ICotton
    {
        public void CottonRequirement()
        {
            Console.WriteLine("Cotton can be required to build Hoodie");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shirt objShirt = new Shirt();
            objShirt.CottonRequirement();
            objShirt.PolyesterRequirement();

            Console.WriteLine();
            Hoodie objHoodie = new Hoodie();
            objHoodie.CottonRequirement();

            //output - 
            //Cotton can be required to build Shirt
            //Polyester can be required to build Shirt

            //Cotton can be required to build Hoodie


        }
    }
}
