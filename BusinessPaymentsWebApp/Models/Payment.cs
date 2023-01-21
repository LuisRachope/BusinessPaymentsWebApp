using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models
{
    //Payment equal "Credits" on View 
    public class Payment
    {
        [Display(Name = "Payment Id")]
        public int Id { get; set; }

        [Display(Name = "Customer")]
        public Customer Customer { get; set; }

        [Display(Name = "Amount")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }

        [Display(Name = "Date Payment")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DatePayment { get; set; }

        public string Remarks { get; set; }

        public int CustomerId { get; set; }


        public Payment()
        {
        }

        public Payment(int id, Customer customer, double amount, DateTime datePayment, string remarks)
        {
            Id = id;
            Customer = customer;
            Amount = amount;
            DatePayment = datePayment;
            Remarks = remarks;
        }
    }
}
