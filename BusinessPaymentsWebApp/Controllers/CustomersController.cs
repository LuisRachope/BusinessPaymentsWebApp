using BusinessPaymentsWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CustomerServices _customerServices;

        public CustomersController(CustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        public async Task<IActionResult> Index()
        {
            var obj = await _customerServices.FindAllAsync();
            return View(obj);
        }
    }
}
