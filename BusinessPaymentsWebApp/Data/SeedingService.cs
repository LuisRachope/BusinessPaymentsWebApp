using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessPaymentsWebApp.Data
{
    public class SeedingService
    {
        private BusinessPaymentsContext _context;

        public SeedingService(BusinessPaymentsContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //if (_context.?????.Any()) - Here de model center class
            {
                return; // DB has been seeded
            }

            // Creation data to migration on DB (EF)

            // Creation data of Customers

            // Execution saving data

        }
    }
}
