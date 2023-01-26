using BusinessPaymentsWebApp.Data;
using BusinessPaymentsWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Services
{
    public class PaymentServices
    {
        private readonly BusinessPaymentsContext _context;

        public PaymentServices(BusinessPaymentsContext context)
        {
            _context = context;
        }

        public async Task<List<Payment>> FindAllAsync()
        {
            return await _context.Payment.ToListAsync();
        }

        public async Task<Payment> FindByIdAsync(int id)
        {
            return await _context.Payment.FindAsync(id);
        }

        public async Task RemoveAsync(Payment payment)
        {
            _context.Remove(payment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Payment payment)
        {
            _context.Update(payment);
            await _context.SaveChangesAsync();
        }

        public async Task CreateAsync(Payment payment)
        {
            _context.Add(payment);
            await _context.SaveChangesAsync();
        }
    }
}
