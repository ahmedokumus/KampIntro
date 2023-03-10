using System;

namespace IyiProgramciSerisi_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Ahmed",
                Surname = "Okumus",
                City = "Kütahya"
            };
            Customer customer2 = new Customer(2, "Hakan", "Okumus", "Bursa");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            Console.WriteLine(customer2.Name);
        }

        //static void Method(int id, string firstName, string lastName, string city)
        //{

        //}
    }

    class Customer
    {
        public Customer() 
        {
            
        }
        //default constructor
        //new leme yapınca aşağıdaki yapı varsa o çalışır. Yoksa arka planda oluşur ve çalışır
        public Customer(int id, string name, string surname, string city)
        {
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
            Console.WriteLine("Yapıcı blok çalıştı");
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}