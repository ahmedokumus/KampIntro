using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) 
        {
            product.ProductName = "Kamera";
        }

        public void BiseyYap(int sayi)
        {
            sayi = 90;
        }

    }
}
