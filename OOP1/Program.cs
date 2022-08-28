using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2 numaralı kategori Id mobilya kategorisi olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 499.9;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5, //5 numaralı kategori Id kırtasiye kategorisi olsun
                ProductName = "Kalem",
                UnitsInStock = 5,
                UnitPrice = 29.99
            };

            //PascalCase   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            int sayi = 100;
            productManager.BiseyYap(sayi); //productManager.BiseyYap(sayi) = productManager.BiseyYap(100)
            Console.WriteLine(sayi); //100

            //değer tipleri <-- int, long, float, double, decimal, char, bool, byte, short, struct, enum --> değer tipleri
            //referans tipleri <-- string, object, class, interface, arry, delegate, pointer --> referans tipleri
        }
    }
}
