using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models
{
    //Receivable equal "Payments Recovery" on View 
    public class Receivable
    {
        [Display(Name = "Receivable Id")]
        public int Id { get; set; }

        [Display(Name = "Customer")]
        public Customer Customer { get; set; }

        public string Purchase { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Price { get; set; }

        [Display(Name = "Date Credit")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateCredit { get; set; }

        public string Remarks { get; set; }

        public int CustomerId { get; set; }

        public Receivable()
        {
        }

        public Receivable(int id, Customer customer, string purchase, double price, DateTime dateCredit, string remarks)
        {
            Id = id;
            Customer = customer;
            Purchase = purchase;
            Price = price;
            DateCredit = dateCredit;
            Remarks = remarks;
        }
    }
}
