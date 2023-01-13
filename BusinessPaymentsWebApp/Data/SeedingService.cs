using BusinessPaymentsWebApp.Models;
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
            if (_context.Customer.Any()) //Here de model center class
            {
                return; // DB has been seeded
            }

            // Creation data to migration on DB (EF)

            // Creation data of Customers
            Customer c1 = new Customer(1, "Uriel Septim", "urielseptim@gmail.com", "234568946", "");
            Customer c2 = new Customer(2, "Jonh", "john@gmail.com", "985464633", "");
            Customer c3 = new Customer(3, "Nathan Drake", "nathan@gmail.com", "364864624", "");
            Customer c4 = new Customer(4, "Mark Tomble", "marktom@outlook.com", "468899444", "");
            Customer c5 = new Customer(5, "Martin", "martin18@gmail.com", "864892112", "");
            Customer c6 = new Customer(6, "Albert Weskers", "albertwerks@hotmail.com", "848949846", "");
            Customer c7 = new Customer(7, "Tom Ridle", "tom13@gmail.com", "443496984", "");
            Customer c8 = new Customer(8, "Bill Rian", "billra@hotmail.com", "884683183", "");
            Customer c9 = new Customer(9, "Ullises Brian", "ullises14@hotmail.com", "846346454", "");
            Customer c10 = new Customer(10, "Kain Reaver", "kain2424@outlook.com", "548845496", "");
            _context.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10);

            // Execution saving data
            _context.SaveChanges();
        }
    }
}
