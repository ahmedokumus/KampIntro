using System;

namespace IyiProgramciSerisi_RefereceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, long, float, double, decimal, char, bool, byte, short, struct, enum => değer tipler
            //array, class, interface, string, object, delegate => referans tipler

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = ?? 999
            

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ahmed";
            person2 = person1;
            person1.FirstName = "Hakan";
            Console.WriteLine(person2.FirstName);

            Employee employee = new Employee();
            employee.FirstName = "Azra";

            Customer customer = new Customer();
            customer.FirstName = "Gurkan";
            customer.CreditCardNumber = "12345";

            Person person3 = customer;
            customer.FirstName = "Egemen";

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer:Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee:Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}