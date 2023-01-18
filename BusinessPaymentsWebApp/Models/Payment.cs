using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models
{
    //Payment equal "Credits" on View 
    public class Payment
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public double Amount { get; set; }
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
