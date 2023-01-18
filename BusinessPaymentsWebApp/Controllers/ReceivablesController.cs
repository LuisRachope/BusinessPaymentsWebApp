using BusinessPaymentsWebApp.Models;
using BusinessPaymentsWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Controllers
{
    public class ReceivablesController : Controller
    {
        private readonly ReceivableServices _receivableServices;
        private readonly CustomerServices _customerServices;

        public ReceivablesController(ReceivableServices receivableServices, CustomerServices customerServices)
        {
            _receivableServices = receivableServices;
            _customerServices = customerServices;
        }

        public async Task<IActionResult> Index()
        {
            var receivables = await _receivableServices.FindAllAsync();
            var customers = await _customerServices.FindAllAsync();

            List<Receivable> list = new List<Receivable>();
            foreach (var obj in receivables)
            {
                list.Add(new Receivable(obj.Id,
                    customers.FirstOrDefault(x => x.Id == obj.CustomerId),
                    obj.Purchase,
                    obj.Price,
                    obj.DateCredit,
                    obj.Remarks
                    ));
            }

            return View(list);
        }
    }
}
