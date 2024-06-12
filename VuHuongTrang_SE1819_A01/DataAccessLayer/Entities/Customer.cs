using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }
        public string EmailAddress { get; set; }
        public string TelePhone { get; set; }
        public DateOnly CustomerBirthday { get; set; }
        public bool CustomerStatus { get; set; }
        public string CustomerAddress { get; set; }
        public string Password { get; set; }
    }
}
