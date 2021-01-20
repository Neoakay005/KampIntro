using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety
            string kategoriEtiketi = "Kategori";
            Console.WriteLine("Hello World!");
            Console.WriteLine(kategoriEtiketi);

            int ogrenciSayisi = 32000;
            double vaadeOrani = 1.45;
            bool sistemeGirisYamisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Var");
            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Düşüş Var");
            }
            else
            {
                Console.WriteLine("Herhangi bir değişiklik yok");
            }


            if (sistemeGirisYamisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
