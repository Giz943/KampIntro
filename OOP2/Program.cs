using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new CorporateCustomer
            {
                CustomerID = 1,
                CustomerNumber = "12345",
                CompanyName = "Assistt",
                TaxIDNumber = "55659898965"
            };

            Customer customer2 = new GeneralCustomer
            {
                CustomerID = 2,
                CustomerNumber = "12346",
                CustomerName = "Gizem",
                CustomerLastName = "Çınar"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);

            customerManager.Add(customer1);

            customerManager.Delete(customer2);

            customer2.CustomerNumber = "12378";

            customerManager.Update(customer2);






        }
    }
}
