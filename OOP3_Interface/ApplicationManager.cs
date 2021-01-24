using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_Interface
{
    class ApplicationManager
    {
        //bu işleme "method injection" denir
        public void Applicate(ICreditManager creditManager, ILoggerService loggerService)
        {
            // başvuran bilgileri ve değerlendirme
            // Kredi hesaplama
            creditManager.Calculate();
            loggerService.Log();
        }
        public void PreApplicate(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
