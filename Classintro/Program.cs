using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs = new Kurs();
            kurs.Egitmen = "Engin";
            kurs.KursAdi = "C#";
            kurs.IzlenmeOrani = 85;
            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Kerem";
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = 64;
            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Berkay";
            kurs3.KursAdi = "Phyton";
            kurs3.IzlenmeOrani = 80;
            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "Atilla";
            kurs4.KursAdi = "Phyton";
            kurs4.IzlenmeOrani = 800;


            Kurs[] Kurslar = new Kurs[] { kurs, kurs2, kurs3, kurs4 };
            foreach (var x in Kurslar)
            {
                Console.WriteLine(x.Egitmen +" "+x.KursAdi+" "+x.IzlenmeOrani);
            }


            Console.WriteLine(kurs.Egitmen);
            Console.WriteLine(kurs.KursAdi);
            Console.WriteLine(kurs.IzlenmeOrani);
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}
