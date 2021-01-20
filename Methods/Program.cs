using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Name = "Elma";
            urun1.Price = 2.55;
            urun1.Description = "Golden Elma";

            Product urun2 = new Product();
            urun2.Name = "Karpuz";
            urun2.Price = 6.50;
            urun2.Description = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Description);
                Console.WriteLine("-------------");
            }
            // instance 
            Console.WriteLine("-------------Method-------------");
            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(urun1);
            basketManager.Ekle(urun2);
        }
    }
}


// Don't repeat yourself DRY = methods / Clean Code / Best Practice
// Type safe (tipleri C sharp bilmek istiyor)