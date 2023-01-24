using BusinessPaymentsWebApp.Models;
using BusinessPaymentsWebApp.Models.ViewModels;
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

        public async Task<IActionResult> Details(int id)
        {
            var receivable = await _receivableServices.FindByIdAsync(id);
            var customer = await _customerServices.FindByIdAsync(receivable.CustomerId);

            Receivable obj = new Receivable(
                receivable.Id,
                customer,
                receivable.Purchase,
                receivable.Price,
                receivable.DateCredit,
                receivable.Remarks
                );

            return View(obj);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var receivable = await _receivableServices.FindByIdAsync(id);
            var customer = await _customerServices.FindByIdAsync(receivable.CustomerId);

            Receivable obj = new Receivable(
                receivable.Id,
                customer,
                receivable.Purchase,
                receivable.Price,
                receivable.DateCredit,
                receivable.Remarks
                );

            return View(obj);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Delete(Receivable receivable)
        {
            await _receivableServices.RemoveAsync(receivable);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var receivable = await _receivableServices.FindByIdAsync(id);
            List<Customer> customers = await _customerServices.FindAllAsync();

            ReceivableFormViewModel viewModel = new ReceivableFormViewModel { Receivable = receivable, Customers = customers };

            return View(viewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Edit(Receivable receivable)
        {
            await _receivableServices.UpdateAsync(receivable);

            return RedirectToAction(nameof(Index));
        }
    }
}
