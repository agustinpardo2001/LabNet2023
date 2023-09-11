using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic <Customers, string>
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public bool Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
            return true;
        }

        public bool Delete(string id)
        {
            var customerDelete = context.Customers.Find(id);
            context.Customers.Remove(customerDelete);
            context.SaveChanges();
            return true;
        }

        public bool Update(Customers customer)
        {
            var customerUpdate = context.Customers.Find(customer.CustomerID);
            customerUpdate.Phone = customer.Phone;
            customerUpdate.ContactName = customer.ContactName;

            context.SaveChanges();
            return true;
        }

    }
}
