using BusinessPaymentsWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Data
{
    public class BusinessPaymentsContext : IdentityDbContext
    {
        public BusinessPaymentsContext(DbContextOptions<BusinessPaymentsContext> options)
            : base(options)
        {
        }

        //Add models hero to instance on Entity Framework
        public DbSet<Customer> Customer { get; set; }

    }
}
