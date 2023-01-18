using BusinessPaymentsWebApp.Models;
using BusinessPaymentsWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly PaymentServices _paymentServices;
        private readonly CustomerServices _customerServices;

        public PaymentsController(PaymentServices paymentServices, CustomerServices customerServices)
        {
            _paymentServices = paymentServices;
            _customerServices = customerServices;
        }

        public async Task<IActionResult> Index()
        {
            var payments = await _paymentServices.FindAllAsync();
            var customers = await _customerServices.FindAllAsync();

            List<Payment> list = new List<Payment>();
            foreach (var obj in payments)
            {
                list.Add(new Payment(obj.Id,
                    customers.FirstOrDefault(x => x.Id == obj.CustomerId),
                    obj.Amount,
                    obj.DatePayment,
                    obj.Remarks
                    ));
            }

            return View(list);
        }
    }
}
