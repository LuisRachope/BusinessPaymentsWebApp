using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models
{
    //Receivable equal "Payments Recovery" on View 
    public class Receivable
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public string Purchase { get; set; }
        public double Price { get; set; }
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
