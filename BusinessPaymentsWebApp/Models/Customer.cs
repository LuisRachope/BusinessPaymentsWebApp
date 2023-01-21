using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models
{
    public class Customer
    {
        [Display(Name = "Customer Id")]
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Remarks { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string name, string email, string phoneNumber, string remarks)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Remarks = remarks;
        }
    }
}
