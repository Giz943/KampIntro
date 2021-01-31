using System;
namespace OOP1
{    //snippet: hazır kodlar
     //product : ürün
    class Product
    {

        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }


        //Beyaz alanlardaki yazanlar referans alanlarıdır.
        //UnitInStock: stok adedi
        //ProductName: Ürün ismi
        //UnitPrice: Ürün birim fiyatı




    }
}
