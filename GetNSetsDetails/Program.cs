using System;

namespace GetNSetsDetails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 0003;
            customer1.Name = "Herbin";
            Console.WriteLine(customer1.Name);
        }
    }
}
