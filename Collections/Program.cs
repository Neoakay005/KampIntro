using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Halil", "Ömer", "Esad", "Hamza" };

            // arrayden belirli indeksi yazdırma
            Console.WriteLine(isimler[3]);

            // arrayden belirli indeksi değiştirme ve yazdırma
            isimler[1] = "Metin";
            Console.WriteLine(isimler[3]);

            //arraya ekleme yapılamıyor. Pythondaki Tuple gibi!!! O yüzden collection kullanılır

            List<string> isimler2 = new List<string> { "Halil", "Ömer", "Esad", "Hamza" };
            Console.WriteLine(isimler2[2]);
            // listeye ekleme yapma
            isimler2.Add("İsa");
        }
    }
}
