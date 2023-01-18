using BusinessPaymentsWebApp.Data;
using BusinessPaymentsWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Services
{
    public class CustomerServices
    {
        private readonly BusinessPaymentsContext _context;

        public CustomerServices(BusinessPaymentsContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> FindAllAsync()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> FindByIdAsync(int id)
        {
            return await _context.Customer.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = _context.Customer.Find(id);
            _context.Customer.Remove(obj);
            await _context.SaveChangesAsync();
        }

        internal async Task UpdateAsync(Customer customer)
        {
            _context.Customer.Update(customer);
            await _context.SaveChangesAsync();
        }
    }
}
