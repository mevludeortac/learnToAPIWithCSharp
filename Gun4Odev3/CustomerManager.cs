using System;
namespace Gun4Odev3
{
    public class CustomerManager
    {
        public  void MusteriEkle(Customer customer)
        {
            Console.WriteLine( customer.Name + " " +  customer.Surname +  " " + "added ");
        }
        public void MusteriSil( Customer customer )
        {
            Console.WriteLine( customer.Name + " " + customer.Surname + " " + "deleted ");
        }
        public void MusteriListele( Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname  );
            }
        }
    }
}
