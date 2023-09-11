using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EF.UI
{
    internal interface IAMBUI<idType>
    {
        void GetAll();
        bool Add(string name, string phone);
        bool Delete(idType shipperId);
        bool Update(idType shipperId, string shipperPhone);


    }
}
