using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Phyton", "C++" };
            Console.WriteLine("Foreach Başladı");
            foreach (var x in kurslar)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Forech Bitti");
            Console.WriteLine("For Başladı");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.ReadLine();
        }

    }
}
