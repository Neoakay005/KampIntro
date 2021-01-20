using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        // naming convention
        // syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete Eklendi " + urun.Name);
        }

        /* ÖNEMLİ: Zamanla değiştirme olasılığından dolayı çoklu 
         * parametreli metodlardan kaçınılmalıdır*/
         
    }
}
