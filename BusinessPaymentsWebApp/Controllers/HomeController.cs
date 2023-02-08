using BusinessPaymentsWebApp.Models;
using BusinessPaymentsWebApp.Models.ViewModels;
using BusinessPaymentsWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly CustomerServices _customerServices;
        private readonly PaymentServices _paymentServices;
        private readonly ReceivableServices _receivableServices;

        public HomeController(CustomerServices customerServices, PaymentServices paymentServices, ReceivableServices receivableServices)
        {
            _customerServices = customerServices;
            _paymentServices = paymentServices;
            _receivableServices = receivableServices;
        }

        public IActionResult Index()
        {
            //Listas do dashboard na página home
            List<Customer> customers = _customerServices.FindAllAsync().Result;
            List<Payment> payments = _paymentServices.FindAllAsync().Result;
            List<Receivable> receivables = _receivableServices.FindAllAsync().Result;

            var obj = new Dashboard { TotalClients = customers.Count(), 
                                      TotalCredits = payments.Count(), 
                                      TotalRecovery = receivables.Count(), 
                                      TotalPedingAmounts = 0 
            };

            return View(obj);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["Student"] = "Luis Rachope";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
