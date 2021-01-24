using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DersOdevi
{
    class PlayerManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Eklendi");
        }
        public void Delete(IPerson person)
        {
            Console.WriteLine("Silindi");
        }
        public void Update(IPerson person)
        {
            Console.WriteLine("Güncellendi");
        }
        public void Check(IPerson person)
        {
            if (person.TcNumber != null && person.FirsName!=null && person.LastName != null && person.BirthDate != null)
            {
                Console.WriteLine("Oyuncu Mevcut");
            }
            else
            {
                Console.WriteLine("Oyuncu Mevcut Değil");
            }
            
        }
    }
}
