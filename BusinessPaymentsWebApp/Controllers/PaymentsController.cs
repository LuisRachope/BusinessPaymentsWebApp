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

        public async Task<IActionResult> Details(int id)
        {
            var payment = await _paymentServices.FindByIdAsync(id);
            var customer = await _customerServices.FindByIdAsync(payment.CustomerId);

            Payment obj = new Payment(
                payment.Id,
                customer,
                payment.Amount,
                payment.DatePayment,
                payment.Remarks
                );

            return View(obj);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var payment = await _paymentServices.FindByIdAsync(id);
            var customer = await _customerServices.FindByIdAsync(payment.CustomerId);

            Payment obj = new Payment(
                payment.Id,
                customer,
                payment.Amount,
                payment.DatePayment,
                payment.Remarks
                );

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Payment payment)
        {
            await _paymentServices.RemoveAsync(payment);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var payment = await _paymentServices.FindByIdAsync(id);

            List<Customer> customers = await _customerServices.FindAllAsync();

            PaymentFormViewModel viewModel = new PaymentFormViewModel { Payment = payment, Customers = customers };

            return View(viewModel);
        }

        [ValidateAntiForgeryTokenAttribute]
        [HttpPost]
        public async Task<IActionResult> Edit(Payment payment)
        {
            await _paymentServices.UpdateAsync(payment);

            return RedirectToAction(nameof(Index));
        }
    }
}
