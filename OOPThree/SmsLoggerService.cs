using System;
namespace OOPThree
{
    public class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("logged to sms");

        }
    }
}
