using System;
using System.Collections.Generic;

namespace OOP3_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager housingCreditManager = new HousingCreditManager();
            // HousingCreditManager housingCreditManager = new HousingCreditManager(); şekilde de yazılabilir
            //housingCreditManager.Calculate();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            ICreditManager needCreditManager = new NeedCreditManager();
            //needCreditManager.Calculate();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //ekrendan gerçekleşen UI kısım
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Applicate(vehicleCreditManager,databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager,vehicleCreditManager};
            //applicationManager.PreApplicate(credits);

            /* Interface sistemi ile daha sonra örn. Esnaf kredisi eklemek istersek sadece
             * yeni class ekler, interface tanımlar, şablonu çağırır ve sonra çağırıldığı 
             * yere instance (newlemek) uygular ve çalıştırırız */
        }
    }
}
