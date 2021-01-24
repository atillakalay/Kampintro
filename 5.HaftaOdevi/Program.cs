using _5.HaftaOdevi.Customer;
using System;

namespace _5.HaftaOdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerBase customer = new RealCustomer();
            customer.Id = 1;
            customer.CustomerFirstName = "Atilla";


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);

            

            
        }
    }
}
