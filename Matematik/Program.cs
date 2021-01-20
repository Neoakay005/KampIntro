using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortluIslem dortluIslem = new DortluIslem();
            dortluIslem.Toplama(2, 3);
            dortluIslem.Toplama(5, 5);

            dortluIslem.Cikarma(10, 3);

            dortluIslem.Carpma(3, 3);

            dortluIslem.Bolme(9, 3);
        }
    }
}
