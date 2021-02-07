using System;
using OOP3.Abstract;

namespace OOP3.Concrete
{
    public class SmsLoggerService : ILoggerService
    {
        public SmsLoggerService()//SMS ile loglama 
        {
        }

        public void Log()
        {
            Console.WriteLine("Sms yolu ile loglama işlemi yapıldı");
        }
    }
}
