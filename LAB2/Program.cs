using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {

            Address someAddress = new Address();

            someAddress.Index = 12345;
            someAddress.Country = "Ukraine";
            someAddress.City = "Kyiv";
            someAddress.Street = "Bulgakova";
            someAddress.House = 20;
            someAddress.Apartment = 356;


            Console.WriteLine($"Index:{someAddress.Index}; Country:{someAddress.Country}; City:{someAddress.City}; Street :{someAddress.Street}; House:{someAddress.House}; Apartment:{someAddress.Index}");

        
        }
    }
}
