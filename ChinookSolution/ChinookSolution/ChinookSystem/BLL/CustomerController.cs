using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel; // for ODS
using ChinookSystem.Data.Entities;
using ChinookSystem.Data.POCOs;
using ChinookSystem.DAL;
#endregion

namespace ChinookSystem.BLL
{[DataObject]
   public class CustomerController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<RepresentativeCustomer> RepresentativeCustomer_Get(int employeeId)
        {
            using (var context = new ChinookContext())
            {
                var results = from x in context.Customer
                              where x.SupportRepId == employeeId
                              orderby x.LastName, x.FirstName
                              select new RepresentativeCustomer
                              {

                                  Name = x.LastName + "," + x.FirstName,
                                  City = x.City,
                                  State = x.State,
                                  Phone = x.Phone,
                                  Emaill = x.Emaill,
                              };
                return results.ToList();
            }

        }
    }
}
