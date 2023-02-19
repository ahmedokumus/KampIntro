using System;

namespace OOP1;

public class ProductManager
{
    //encapsulation
    public void Add(Product product)
    {
        //Ekleme kodları buraya yazılır.
        Console.WriteLine(product.ProductName + " Eklendi.");
    }

    public void Update(Product product)
    {
        Console.WriteLine(product.ProductName + " Güncellendi.");
    }
}