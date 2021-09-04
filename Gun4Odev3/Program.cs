using System;

namespace Gun4Odev3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Simulate");
            Customer customer1 = new Customer();
            {
                customer1.Id = 6;
                customer1.Name = "mert";
                customer1.Surname = "yılmaz";
            }
            Customer customer2 = new Customer();
            {
                customer2.Id = 6;
                customer2.Name = "herbin";
                customer2.Surname = "ortaç";
            }
            Customer customer3 = new Customer();
            {
                customer3.Id = 6;
                customer3.Name = "mevlüde";
                customer3.Surname = "saniye";
            }

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();
            customerManager.MusteriEkle(customer1);
            customerManager.MusteriSil(customer2);
            customerManager.MusteriListele(customers);

        }
    }
}
