using System;

namespace OOP2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //gerçek kişi için veri girişi
            Individual individualCustomer1 = new Individual();
            individualCustomer1.Id = 0001;
            individualCustomer1.CustomerNo = "8765678";
            individualCustomer1.TcId = "98765456789";
            individualCustomer1.FirstName = "herbin";
            individualCustomer1.LastName = "ortaç";

            //tüzel kişi için veri girişi

            Corporation corporationCustomer1 = new Corporation();
            corporationCustomer1.Id = 00001;
            corporationCustomer1.CustomerNo = "9876546789";
            corporationCustomer1.TaxNo = "987654";
            corporationCustomer1.CustomerNo = "5K Reklamcılık";


            //individual ve corparation bellekte referans olarak yer aldıkları için
            //customer classımız bunları referans olarak bellekte tutuyor
            Customer customer1 = new Individual();
            Customer customer2 = new Corporation();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer1);
            customerManager.Add(corporationCustomer1);
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
