using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppi.Service.Interface
{
    public interface IShippersService
    {
        void Add(Shippers shippers);
        void Update(Shippers shippers);
        void Delete(int id);
        List<Shippers> GetAll();
        Shippers GetById(int id);
    }
}
