using System;

namespace OOP2
{
    class Program
    {
        //Bir clastaki özellik o class a ait gibi gözükmüyorsa o class da soyutlama hatası vardır . E.D
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demiroğ";
            musteri1.TcNo = "123456789101";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            customerManager.Add(musteri1);


            //Gerçek - Tüzel birbirine benziyor diye birbirinin yerine kullanılamaz .
            //SOLID
        }
    }
}
