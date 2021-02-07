using System;
using OOP3.Abstract;

namespace OOP3.Concrete
{
    public class CreditType2Manager : ICreditManager
    {
        public CreditType2Manager()
        {
        }

        public void Calculate()//Hesaplandı bilgisi verir.
        {
            Console.WriteLine("Kredi hesaplandı: CreditType2");
        }

        public void Information()//Oranlar hakkında bilgi verir.
        {
            Console.WriteLine("Banka Oranı: 1.7");
        }
    }
}
