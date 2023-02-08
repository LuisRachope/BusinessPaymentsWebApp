using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models.ViewModels
{
    public class Dashboard
    {
        public int TotalClients { get; set; }
        public int TotalCredits { get; set; }
        public int TotalRecovery { get; set; }
        public int TotalPedingAmounts { get; set; }
    }
}
