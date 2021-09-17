using System;

namespace DifferenceBetweenInheritanceAndInterface
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
        }
    }

    interface IPersonManager
    {
        //uniplemented operation: tamamlanmamış operasyon
        //just like signature
        //we need to implement to interface in our class
        void Add();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //adding codes (customer)
            Console.WriteLine("simulated to adding customer");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //adding codes (employee)
            Console.WriteLine("simulated to adding employee");
        }
    }

    //inheritance
    //override and new props are added 

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    class Basket : Product
    {
        public int BasketId { get; set; }
        public double Amount { get; set; }

    }
}
