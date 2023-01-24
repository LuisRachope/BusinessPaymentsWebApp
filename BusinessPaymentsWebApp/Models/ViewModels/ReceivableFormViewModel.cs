using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models.ViewModels
{
    public class ReceivableFormViewModel
    {
        public Receivable Receivable { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
