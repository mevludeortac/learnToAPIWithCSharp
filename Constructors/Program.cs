using System;

namespace Constructors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer customer = new Customer(2, "jay", "z", "los angeles");
            Console.WriteLine(customer.FirsName);

        }
    }

    class Customer
    {
        //cunstructor
        public Customer()
        {

        }
        //default cunstructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirsName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
