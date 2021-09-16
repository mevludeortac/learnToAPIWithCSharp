using System;
using System.Collections.Generic;

namespace OOPThree
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            PersonalFinanceCreditManager personalFinanceCreditManager1 = new PersonalFinanceCreditManager();
            personalFinanceCreditManager1.Calculate();

            TransportCreditManager transportCreditManager1 = new TransportCreditManager();
            transportCreditManager1.Calculate();

            //Interfaceler de kendisini implemente eden classa referans olabilir
            //Bu şekilde de yazabiliriz
            ICreditManager personalFinanceCreditManager2 = new PersonalFinanceCreditManager();
            personalFinanceCreditManager2.Calculate();

            ICreditManager transportCreditManager2 = new TransportCreditManager();
            transportCreditManager2.Calculate();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            //ApplicationManager'da MakeApplication'a kredi parametresi ekledikten sonra
            //seçilen kredi türüne göre o kredinin manager classının içerisindeki
            //operasyonda işlem yapılır.
            ApplicationManager applicationManager1 = new ApplicationManager();
            applicationManager1.MakeApplication(personalFinanceCreditManager1, fileLoggerService);

            ApplicationManager applicationManager2 = new ApplicationManager();
            applicationManager2.MakeApplication(transportCreditManager2, databaseLoggerService);

            List<ILoggerService> loggerServices = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager3 = new ApplicationManager();
            applicationManager3.MakeApplication(personalFinanceCreditManager1, smsLoggerService);
            


            List<ICreditManager> credits = new List<ICreditManager>() {transportCreditManager1, personalFinanceCreditManager1 };
                    //applicationmanager tipinde yazdığımız applicationmanager1 değişkeninin MakeCreditPreInformation operasyonuna krediler listesini yolluyoruz
            //applicationManager1.MakeCreditPreInformation(credits);

        }
    }
}
