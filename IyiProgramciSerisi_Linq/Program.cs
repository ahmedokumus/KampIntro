namespace IyiProgramciSerisi_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category() { CategoryId = 1, CategoryName = "Bilgisayar" },
                new Category() { CategoryId = 2, CategoryName = "Telefon" },
            };

            List<Product> products = new List<Product>
            {
                new Product() {ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 10000, UnitInStock = 5 },
                new Product() { ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 18000, UnitInStock = 3 },
                new Product() { ProductId = 3, CategoryId = 1, ProductName = "Hp Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 18000, UnitInStock = 2 },
                new Product() { ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 5000, UnitInStock = 15 },
                new Product() { ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 8000, UnitInStock = 0 },
            };
            //Console.WriteLine("----------ALGORİTMİK----------");
            //GetProduct(products);

            //Console.WriteLine("----------LİNQ----------");
            //GetProductLinq(products);

            //Anytest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            //ClassicLinqTest1(products);

            //ClassicLinqTest2(products);

            var result = from product in products
                join category in categories on product.CategoryId equals category.CategoryId
                where product.UnitPrice > 5000
                orderby product.UnitPrice descending 
                select new ProductDto { ProductId = product.ProductId, CategoryName = category.CategoryName, ProductName = product.ProductName, UnitPrice = product.UnitPrice };
            foreach (var productDto in result)
            {
                //Console.WriteLine(productDto.ProductName + " -> " + productDto.CategoryName);
                Console.WriteLine("{0} ---> {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest2(List<Product> products)
        {
            var result = from p in products //products -> liste, p-> takma isim
                where p.UnitPrice > 6000 //6000 den büyük olanları getir
                orderby p.UnitPrice descending, p.ProductName
                    ascending //listeyi önce büyükten küçüğe sıralar sonra o listeyide küçükten büyüğe sıralar.
                select new ProductDto() { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice }; //her bir p yi liste yap şarta uyanları ekle.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ClassicLinqTest1(List<Product> products)
        {
            var result = from p in products //products -> liste, p-> takma isim
                where p.UnitPrice > 6000 //6000 den büyük olanları getir
                orderby p.UnitPrice descending, p.ProductName
                    ascending //listeyi önce büyükten küçüğe sıralar sonra o listeyide küçükten büyüğe sıralar.
                select p; //her bir p yi liste yap şarta uyanları ekle.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //Single Line query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice)
                .ThenByDescending(p => p.ProductName);
            foreach (Product product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top")); //Liste dönüyor
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void Anytest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop"); //Var mı yok mu diye bakar
            Console.WriteLine(result);
        }

        static List<Product> GetProduct(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        static List<Product> GetProductLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
        }

        class ProductDto
        {
            public int ProductId { get; set; }
            public string CategoryName { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
        }

        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }//Açıklama
            public decimal UnitPrice { get; set; }
            public int UnitInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}