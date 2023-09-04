using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Logic
{
    public class CustomersLogic
    {
        private readonly NorthWindContext context;

        public CustomersLogic()
        {
            context = new NorthWindContext();
        }
        
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customers GetOne()
        {
            return context.Customers.First();
        }

        public List<Customers> GetByRegionWA()
        {
            return (from c in context.Customers 
                    where c.Region == "WA"
                    select c).ToList();
        }
        public List<string> GetAllNames()
        {
            return (from c in context.Customers
                    select c.CompanyName).ToList();
        }
        public List<CustomersDTO> JoinWithOrders()
        {
            return(from c in context.Customers
                   join o in context.Orders
                   on c.CustomerID equals o.CustomerID
                   where c.Region == "WA" && o.OrderDate > new DateTime(1997, 1, 1)
                   select new CustomersDTO {Region = c.Region, OrderDate = o.OrderDate}).ToList();
        }

        public List<Customers> GetThreeCustomersWA()
        {
            return context.Customers.OrderBy(c => c.Region == "WA").Take(3).ToList();
        }

    }
}
