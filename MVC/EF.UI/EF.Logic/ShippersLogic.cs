
using C.Exceptions;
using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers, int>
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public Shippers FindOne(int? id)
        {
            var shipper = context.Shippers.Find(id);
            if (shipper == null)
            {
                throw new ShipperNullException();
            }
            return shipper;
        }

        public bool Add(Shippers newShipper)
        {
            if (string.IsNullOrEmpty(newShipper.Phone))
            {
                throw new PhoneEmptyException();
            }
            if (string.IsNullOrEmpty(newShipper.CompanyName))
            {
                throw new CompanyNameEmptyException();
            }

            context.Shippers.Add(newShipper);
            context.SaveChanges();
            return true; 
        }

        public bool Delete(int id)
        {
            var shippersDelete = context.Shippers.Find(id);

            if (shippersDelete != null)
            {
                throw new ShipperNullException();
            }

            context.Shippers.Remove(shippersDelete);
            context.SaveChanges();
            return true;
        }

        public bool Update(Shippers shippers)
        {
            var shippersUpdate = context.Shippers.Find(shippers.ShipperID);

            if (shippersUpdate != null)
            {
                throw new ShipperNullException();
            }
            if (string.IsNullOrEmpty(shippers.Phone))
            {
                throw new PhoneEmptyException();
            }

            shippersUpdate.Phone = shippers.Phone;
            context.SaveChanges();
            return true;
        }
    }

}
