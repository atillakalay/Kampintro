using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - Tip Güvenliği 
            string kategoriEtiketi = "Kategori : ";
            int sayi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisaMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Yatay Seyir");
            }




            if (sistemeGirisYapmisaMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }


            Console.WriteLine(kategoriEtiketi + sayi);
            Console.WriteLine(sayi);
            Console.WriteLine(faizOrani);
            Console.WriteLine(sistemeGirisYapmisaMi);

        }
    }
}
