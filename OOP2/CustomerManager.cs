using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2 // Add metodu ile yeni bir müşteri ekleme işlemi
{
    public class CustomerManager
    {
        public void Add(Customer customer)//Her iki customer içinde ekleme Add
        {
            Console.WriteLine("Added customer info  :  {0}", customer.CustomerID);

            
        }

        public void Delete(Customer customer) //Müşteri tamamen şirkeetten ayrıldı gibi.
        {
            Console.WriteLine("Deleted customer info  :  {0}", customer.CustomerID);


        }
        public void Update(Customer customer) 
        {
            Console.WriteLine("Update customer info  :  {0}", customer.CustomerID);


        }






    }
}