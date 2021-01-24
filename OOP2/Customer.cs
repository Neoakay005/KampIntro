using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    /* inheritance örneği (kesin çekilmeyecek 
     * verilerin inheritance göre guruplandırma yapılması) 
     * örneğin burada müşterinin ortak verilerini ortak yerde
     * gerçek-tüzel arklı alanlarını ayırma */
    class Customer
    {
        public int Id { get; set; }
        public byte CustomerNumber { get; set; }
    }

}
