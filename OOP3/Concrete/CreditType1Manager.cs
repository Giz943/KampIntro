using System;
using OOP3.Abstract;

namespace OOP3.Concrete
{
    public class CreditType1Manager: ICreditManager
    {
        public CreditType1Manager()
        {
        }

        public void Calculate()
        {
            Console.WriteLine("Kredi hesaplandı: CreditType1");
        }

        public void Information()
        {
            Console.WriteLine("Banka Oranı: 1.8");
        }
    }
}
