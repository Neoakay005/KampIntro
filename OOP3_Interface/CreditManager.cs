using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Interface
{
    // Interface metodu genellikle operasyonel sınıflarda kullanılır. Interface = kural şablonu
    // Interface yazarken public/static yazılmıyor. Class ismi başına büyük I harfi geliyor. 
    //Class yerine interface anahtar kelimesi kullanılıyor.
    interface ICreditManager
    {
        void Calculate();
        void DoAnything();
    }
}
