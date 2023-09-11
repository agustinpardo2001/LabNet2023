using EF.Entities;
using EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.UI
{
    public class ShippersUI : IAMBUI<int>
    {
        protected ShippersLogic shippersLogic;
        public List<string> idShippers { get; set; }
        public ShippersUI()
        {
            shippersLogic = new ShippersLogic();
            idShippers= new List<string> { };
        }


        public void GetAll()
        {
            Console.WriteLine("****SHIPPERS****");
            foreach (Shippers shipper in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shipper.ShipperID} {shipper.CompanyName} - {shipper.Phone}");
                if(idShippers.Contains(shipper.ShipperID.ToString()) == false)
                {
                    idShippers.Add(shipper.ShipperID.ToString());
                }
            }
        }

        public bool Add(string shipperCompanyName, string shipperPhone)
        {
            return shippersLogic.Add(new Shippers
            {
                CompanyName = shipperCompanyName,
                Phone = shipperPhone
            });
        }

        public bool Update(int shipperid, string shipperPhone)
        {
            return shippersLogic.Update(new Shippers
            {
                ShipperID = shipperid,
                Phone = shipperPhone
            });
        }
        
        public bool Delete(int shipperid)
        {
            shippersLogic.Delete(shipperid);
            idShippers.Remove(shipperid.ToString());
            return true;
            

           
        }

    }
}
