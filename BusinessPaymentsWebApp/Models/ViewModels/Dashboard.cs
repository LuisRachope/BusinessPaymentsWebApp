using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Models.ViewModels
{
    public class Dashboard
    {
        [Display(Name = "Total Clients")]
        public int TotalClients { get; set; }

        [Display(Name = "Total Credits")]
        public int TotalCredits { get; set; }

        [Display(Name = "Total Recovery")]
        public int TotalRecovery { get; set; }

        [Display(Name = "Total Peding Amounts")]
        public int TotalPedingAmounts { get; set; }
    }
}
