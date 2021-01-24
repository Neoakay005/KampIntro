using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // how to create coorperate object
            CustomerCoorperate customerCoorperate = new CustomerCoorperate();
            customerCoorperate.Id = 01;
            customerCoorperate.CompanyName = "akay.io";
            customerCoorperate.CustomerNumber = 2;
            customerCoorperate.TaxNumber = "9234122234";

            // how to create individual object
            CustomerIndividual customerIndividual = new CustomerIndividual();
            customerIndividual.Id = 02;
            customerIndividual.CustomerNumber = 3;
            customerIndividual.FirstName = "Halil";
            customerIndividual.LastName = "Akay";
            customerIndividual.IdNumber = "51234512344";

            // super class can hold all references from its inheritance
            Customer customer3 = new CustomerCoorperate();
            Customer customer4 = new CustomerIndividual();

        }
    }
}
