using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce1.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime EmployeeBirthday { get; set; }
        public string EmployeeBlock { get; set; }
        public string EmployeeLot { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeBaranggay { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePass { get; set; }
        public string Image { get; set; }
        public int RoleID { get; set; }
        public int SecurityID { get; set; }
    }
}
