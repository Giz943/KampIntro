using System;
using System.Collections.Generic;
using OOP3.Abstract;
using OOP3.Concrete;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager creditManager1 = new CreditType1Manager();
            ICreditManager creditManager2 = new CreditType2Manager();

            ILoggerService loggerService1 = new FileLoggerService();
            ILoggerService loggerService2 = new SmsLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(creditManager1, loggerService2);

            List<ICreditManager> creditManagers = new List<ICreditManager> { creditManager1, creditManager2 };
            applicationManager.PreliminaryInformation(creditManagers);
        } 
    }
}
