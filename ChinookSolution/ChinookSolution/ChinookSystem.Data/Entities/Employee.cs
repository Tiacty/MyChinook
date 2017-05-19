using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion
namespace ChinookSystem.Data.Entities
{
    [Table("Employee")]
   public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public  int? ReportsTo { get; set; }
        public DateTime? BirthData { get; set; }
        public DateTime? HireData { get; set; }
        public  string Address { get; set; }
        public  string City { get; set; }
        public  string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Emaill { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
    }
}
