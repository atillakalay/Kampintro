﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi : "+product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi : " + product.ProductName);
        }
      
    }
}
