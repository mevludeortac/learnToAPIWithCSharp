using System;
namespace OOPThree
{
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }
}
