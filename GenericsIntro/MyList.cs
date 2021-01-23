using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // generic type verilmesi <> içine
    // <T> vermem ona tanımlanacak olan type kabul görecektir.
    class MyList<T>
    {
        T[] items;
        // constructor (class bir yerde new'lenirse otomaik çalışır)
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            // geçici ara depolama oluşturulur. Çünkü sonraki adımda
            // heap'deki referans kaçırılmış olacak.
            T[] tempArray = items;
            // yukarıda listede artırma yapılamayacağı için 
            // artırma bu şekilde yapılıyor.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

    }
}
