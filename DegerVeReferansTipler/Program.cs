using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            int[] sayilar1 = { 10, 20, 30 };
            int[] sayilar2 = { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

        }
    }
}
