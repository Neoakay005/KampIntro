using System;

namespace ClassOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Brand = "HP";
            product1.ProductName = "ProBook 450 Laptop";
            product1.ProductPrice = 5649.99;
            product1.FreeShipping = true;

            Product product2 = new Product();
            product2.Brand = "ASUS";
            product2.ProductName = "Vivobook N3350 Laptop";
            product2.ProductPrice = 3599.99;
            product2.FreeShipping = false;

            Product product3 = new Product();
            product3.Brand = "APPLE";
            product3.ProductName = "MacBook Air Laptop";
            product3.ProductPrice = 7168.99;
            product3.FreeShipping = true;

            Product product4 = new Product();
            product4.Brand = "LENOVO";
            product4.ProductName = "V15 Laptop";
            product4.ProductPrice = 6499.98;
            product4.FreeShipping = true;

            Product[] products = new Product[] { product1, product2, product3, product4 };

            // foreach ile ürünlerin yazdırılması
            Console.WriteLine("--------foreach--------");
            foreach (var laptops in products)
            {
                Console.WriteLine(laptops.ProductName);
            }

            Console.WriteLine("--------for--------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName);
            }

            Console.WriteLine("--------while--------");
            int x = 0;
            do
            {
                Console.WriteLine(products[x].ProductName);
                x++;
            }
            while (x < products.Length);
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public double ProductPrice { get; set; }
        public bool FreeShipping { get; set; }
    }
}
