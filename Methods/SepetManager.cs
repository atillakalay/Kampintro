using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
   public class SepetManager 
    {
       public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler , Sepete Eklendi ! "+product.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdeti)
        {
            Console.WriteLine("Tebrikler , Sepete Eklendi ! " + urunAdi);
        }
    }
}
