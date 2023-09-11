using EF.Entities;
using EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.UI
{
    public class CustomersUI
    {
        protected CustomersLogic customersLogic;
        public CustomersUI()
        {
            customersLogic = new CustomersLogic();
        }
        public void GetAll()
        {
            Console.WriteLine("****CUSTOMERS****");
            Console.WriteLine(" ");

            foreach (Customers customer in customersLogic.GetAll())
            {
                Console.WriteLine($"{customer.CustomerID} {customer.CompanyName} - {customer.Phone}");
            }
        }
    }
}
