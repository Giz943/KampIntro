using System;
using System.Collections.Generic;
using OOP3.Abstract;

namespace OOP3.Concrete
{
    public class ApplicationManager//Örneğin; bankadaki faiz hesaplama işlemi yapma ve banka  
        //faiz oranı görüntüleme işlemlerini yapacağım zaman kullanırım.
    {
        public ApplicationManager()
        {

        }

        public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService)//Kullanılmak istenilen creditmanager(örn banka bilgisi)
            //ile hesaplama yapılır,kullanılmak istenilen log service ile loglama işlemi yapılır.
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void PreliminaryInformation(List<ICreditManager> creditManagerList) //Örneğin;Listedeki tüm bankalar için faiz
            //oranı görüntüleme işlemlerini yapacağım zaman kullanırım.
        {
            foreach (var creditManager in creditManagerList)
            {
                creditManager.Information();
            }
        }


    }
}
