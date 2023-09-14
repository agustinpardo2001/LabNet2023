using EF.Entities;
using EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppi.Service.Interface;


namespace WebAppi.Service
{
    public class ShippersService : IShippersService
    {
        private readonly ShippersLogic repository;
        public ShippersService()
        {
            repository = new ShippersLogic();
        }

        public void Add(Shippers shipper)
        {
            repository.Add(shipper);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public List<Shippers> GetAll()
        {
            return repository.GetAll();
        }

        public Shippers GetById(int id)
        {
            return repository.FindOne(id);
        }

        public void Update(Shippers shipper)
        {
            repository.Update(shipper);
        }
    }
}




