using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // ilk olarak class Kurs tanımla
            // sonra objeleri oluştur
            // ve array çıkar
            // son olarak foreach ile çağır.


            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Halil İbrahim Akay";
            kurs1.KursAdi = "Python";
            kurs1.IlerlemeDurummu = 80;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Mustafa Murat Coşkun";
            kurs2.KursAdi = "C++";
            kurs2.IlerlemeDurummu = 70;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Sadık Turan";
            kurs3.KursAdi = "Web Geliştirme";
            kurs3.IlerlemeDurummu = 90;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IlerlemeDurummu { get; set; }
    }
}
