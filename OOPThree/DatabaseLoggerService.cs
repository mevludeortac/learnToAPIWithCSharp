using System;
namespace OOPThree
{
    public class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("logged to database");
        }
    }
}
