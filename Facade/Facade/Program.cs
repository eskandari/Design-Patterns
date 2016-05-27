using System;

namespace Facade
{
   class MainApp
    {
        static void Main()
        {


            Mortgage mortgage = new Mortgage();

            Customer customer = new Customer("Ehsan");

            bool eligible = mortgage.IsEligible(customer, 125000);



            Console.WriteLine("\n" + customer.Name +

                " has been " + (eligible ? "Approved" : "Rejected"));

            Console.ReadKey();

        }
    }
}