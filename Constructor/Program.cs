using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance
            Customer customer1 = new Customer{ Id=1, Name="Halil", Surname="Akay", City="Sakarya"};
            Console.WriteLine(customer1.Name);

            // constructor yapı tanımlı iken tanımlama
            Customer customer2 = new Customer(2, "Metin", "Akay", "Sakarya");
            Console.WriteLine(customer2.Name);

        }
    }
    class Customer
    {
        public Customer()
        {

        }
        // constructor tanımlama
        public Customer(int id, string name, string surname, string city)
        {
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
