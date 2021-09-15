using System;

namespace OOP3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PersonalFinanceCredit personalFinanceCredit1 = new PersonalFinanceCredit();
            personalFinanceCredit1.Calculate();

            TransportCredit transportCredit1 = new TransportCredit();
            transportCredit1.Calculate();

            //Interfaceler de kendisini implemente eden classa referans olabilir
            //Bu şekilde de yazabiliriz
            ICreditManager personalFinanceCredit2 = new PersonalFinanceCredit();
            personalFinanceCredit2.Calculate();
            ICreditManager transportCredit2 = new TransportCredit();
            transportCredit2.Calculate();

            //ApplicationManager'da MakeApplication'a kredi parametresi ekledikten sonra
            //seçilen kredi türüne göre o kredinin manager classının içerisindeki
            //operasyonda işlem yapılır.
            ApplicationManager applicationManager1 = new ApplicationManager();
            applicationManager1.MakeApplication(PersonalFinanceCreditManager);
        }
    }
}
