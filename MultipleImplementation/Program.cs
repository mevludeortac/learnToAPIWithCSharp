using System;

namespace MultipleImplementation
{
    class MainClass
    {
        public static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
    }

        interface IWorker
            {
                void Work();
            }

        interface IEat
            {
                void Eat();
            }

        interface ISalary
            {
               void GetSalary();
            }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    } 
}
        
