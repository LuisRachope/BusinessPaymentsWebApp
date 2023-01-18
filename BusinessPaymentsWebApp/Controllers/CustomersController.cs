using BusinessPaymentsWebApp.Models;
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

        public async Task<IActionResult> Details(int id)
        {
            var obj = await _customerServices.FindByIdAsync(id);
            return View(obj);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _customerServices.FindByIdAsync(id);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            await _customerServices.RemoveAsync((int)id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var obj = await _customerServices.FindByIdAsync(id);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Customer customer)
        {
            await _customerServices.UpdateAsync(customer);
            return RedirectToAction(nameof(Index));
        }

    }
}
