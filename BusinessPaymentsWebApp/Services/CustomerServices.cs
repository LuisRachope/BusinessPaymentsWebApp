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
    }
}
