using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    public class CorporateCustomer : Customer // Corporate customerın bir customer olduğunu belirttik.
    {
        public string TaxIDNumber { get; set; }// Vergi kimlik no
        public string CompanyName { get; set; }
    }
}