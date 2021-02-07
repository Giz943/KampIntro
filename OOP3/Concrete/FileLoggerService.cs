using System;
using OOP3.Abstract;// ILoggerService i kullanabilmesi için eklendi.

namespace OOP3.Concrete
{
    public class FileLoggerService : ILoggerService
    {
        public FileLoggerService() //Dosyaya loglama
        {

        }

        public void Log()
        {
            Console.WriteLine("Dosyaya Loglama işlemi yapıldı");
        }
    }
}
