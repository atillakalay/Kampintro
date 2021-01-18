using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    public class CustomerManager
    {

        public void Ekle(Customer customer)
        {
            Console.WriteLine("Müşteri Bankaya Eklendi ." + customer.CustomerName+" "+ customer.CustomerLastName+" "+ customer.Id +" "+customer.CustomerNo);
        }
        public void Sil(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi  . " +customer.CustomerName + " " + customer.CustomerLastName + " " + customer.Id + " " + customer.CustomerNo);
        }
        public void Listele(Customer customer)
        {
            Console.WriteLine("Müşteri Listelendi : " + customer.CustomerName + " " + customer.CustomerLastName + " " + customer.Id + " " + customer.CustomerNo);
        }
        public void Guncelle(Customer customer)
        {
            Console.WriteLine("Müşteri Bilgileri Güncellendi " + customer.CustomerName + " " + customer.CustomerLastName + " " + customer.Id + " " + customer.CustomerNo);
        }

    }
}
