﻿using System;

namespace OOP
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.!");
        }

        public void Sil(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi.!");
        }
    }
}