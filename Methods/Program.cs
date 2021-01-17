using System;



namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            SepetManager sepetManager = new SepetManager();
            product1.Adi = "Elma";
            product1.Id = 1;
            product1.Aciklama = "Amasya Elması";
            product1.Fiyat = 6;
            product1.StokAdedi = 6;


            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Id = 2;
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Fiyat = 80;
            product2.StokAdedi = 80;


            Product[] Urunler = {product1,product2 };

            foreach (Product product in Urunler)
            {
                Console.WriteLine(product.Id +" "+ product.Adi +" "+ product.Fiyat+" "+ product.Aciklama);
                Console.WriteLine("---------------------------------");                      
            }
            Console.WriteLine("------------------Metotlar---------------");           
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuz", 12,8);

        }
    }
}
