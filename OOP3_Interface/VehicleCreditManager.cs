using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Interface
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
