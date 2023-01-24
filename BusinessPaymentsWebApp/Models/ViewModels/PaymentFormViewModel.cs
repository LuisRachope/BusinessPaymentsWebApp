using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models.ViewModels
{
    public class PaymentFormViewModel
    {
        public Payment Payment { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
