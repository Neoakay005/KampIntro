using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortluIslem
    {
        public void Toplama(int deger1, int deger2)
        {
            int toplama = deger1 + deger2;
            Console.WriteLine("Değerlerin toplamı: " + toplama);
        }

        public void Cikarma(int deger1, int deger2)
        {
            int cikarma = deger1 - deger2;
            Console.WriteLine("Çıkartma İşlemi Sonucu: " + cikarma);
        }

        public void Carpma(int deger1, int deger2)
        {
            int carpma = deger1 * deger2;
            Console.WriteLine("Çarpma İşlemi Sonucu: " + carpma);
        }

        public void Bolme(int deger1, int deger2)
        {
            int bolme = deger1 / deger2;
            Console.WriteLine("Bölme İşlemi Sonucu: " + bolme);
        }
    }
}
