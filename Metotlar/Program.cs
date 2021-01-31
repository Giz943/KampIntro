using System;

namespace Metotlar
{
    class MainClass
    {
        static void Main(string[] args)
        {

            Urunn urun1 = new Urunn();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urunn urun2 = new Urunn();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urunn[] urunler = new Urunn[] { urun1, urun2 };

            //type-safe -- tip güvenliği

            foreach (Urunn urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------");
            }


            Console.WriteLine("-------Metotlar-------");

            //instance:clas örneği oluşturma
            //encapsulation:KAPSÜLLEME: ayrı yazılıp düzensiz olan yapıyı
            
            //bir kapsulün içine sokup düzene koyma urun eklendiğinde
            //public  de dahil etmiş-
            //oldun ve hiç bi sayfa etkilenmedi.
            //cw:tab tab console.WriteLine olur.



            SepetManegar sepetManegar = new SepetManegar();
            sepetManegar.Ekle(urun1);
            sepetManegar.Ekle(urun2);


            sepetManegar.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManegar.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManegar.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

         


           
              
        }
    }
}
