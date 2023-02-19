using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id = 1,
                CategoryId = 2, //Mobilya
                ProductName = "Masa",
                UnitPrice = 500,
                UnitInStock = 3
            };

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 5;
            product2.ProductName = "Kalem";
            product2.UnitPrice = 35;
            product2.UnitInStock = 5;

            //PascalCase - //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

        }
    }
}