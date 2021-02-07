using System;
namespace OOP1
{
    class ProductManager //Ürünle ilgili operasyonlar var demek(eklemre,
                         //güncelleme gibi)
    {    //encapsulation
        public void Add(Product product)//101
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}
