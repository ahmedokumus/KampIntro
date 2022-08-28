using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } //Id
        public int CategoryId { get; set; } //Categori adı
        public string ProductName { get; set; } //Ürün ismi
        public double UnitPrice { get; set; } //Ürün fiyatı
        public int UnitsInStock { get; set; } // Stok adedi

        //CRUD operasyoları // Create - Eklemek / Read - Okumak / Update - Güncellemek / Delete - Silmek
    }
}
