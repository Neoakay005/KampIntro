using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Interface
{
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
