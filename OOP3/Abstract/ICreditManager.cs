using System;
namespace OOP3.Abstract
{
    public interface ICreditManager// I = Interface = arayüz
    {//Kredi işlemini gerçekleştirecek metotlar belirtilir.Blirtilen
        //metotların eklenmesi ve kullanılması bu alan ile gerçekleşir.

        void Calculate(); //Hesaplamamızı sağlayacak
        void Information(); //Bilgi verme sağlayacak 

    }
}
