using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            //--------------------------------------
            //arrays
            Console.WriteLine("---for bölümü---");
            string[] kurslar = new string[] { 
                "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temek kurs", 
                "Java"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //--------------------------------------
            Console.WriteLine("---foreach bölümü---");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
