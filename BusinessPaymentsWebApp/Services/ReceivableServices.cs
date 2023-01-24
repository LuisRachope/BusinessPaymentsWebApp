using BusinessPaymentsWebApp.Data;
using BusinessPaymentsWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Services
{
    public class ReceivableServices
    {
        private readonly BusinessPaymentsContext _context;

        public ReceivableServices(BusinessPaymentsContext context)
        {
            _context = context;
        }

        public async Task<List<Receivable>> FindAllAsync()
        {
            return await _context.Receivable.ToListAsync();
        }

        public async Task<Receivable> FindByIdAsync(int id)
        {
            return await _context.Receivable.FindAsync(id);
        }

        public async Task RemoveAsync(Receivable receivable)
        {
            _context.Remove(receivable);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Receivable receivable)
        {
            _context.Update(receivable);
            await _context.SaveChangesAsync();
        }
    }
}
