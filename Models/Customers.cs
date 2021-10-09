using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce1.Models
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public int MessageID { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPass { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime CustomerBirthday { get; set; }
        public string CustomerBlock { get; set; }
        public string CustomerLot { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerBaranggay { get; set; }
        public DateTime CustomerUserCreation { get; set; }
        public string Image { get; set; }
    }
}
