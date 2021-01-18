using System;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer = new Customer();
            customer.Id = 1;
            customer.CustomerName = "Atilla";
            customer.CustomerLastName = "Kalay";
            customer.CustomerNo = 000001;

            customerManager.Ekle(customer);
            customerManager.Sil(customer);
            customerManager.Listele(customer);
            customerManager.Guncelle(customer);
        }
    }
}
