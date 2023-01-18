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

            // Creation data of Payments
            Payment p1 = new Payment(1, c4, 1468.66, new DateTime(2022, 12, 13), "Receivable support Tv");
            Payment p2 = new Payment(2, c2, 456.91, new DateTime(2022, 11, 24), "");
            Payment p3 = new Payment(3, c4, 334.49, new DateTime(2022, 04, 03), "");
            Payment p4 = new Payment(4, c10, 489.84, new DateTime(2022, 09, 11), "");
            Payment p5 = new Payment(5, c8, 584.56, new DateTime(2023, 01, 09), "");
            Payment p6 = new Payment(6, c6, 894.64, new DateTime(2023, 01, 14), "");
            _context.AddRange(p1, p2, p3, p4, p5, p6);

            // Creation data of Receivables
            Receivable r1 = new Receivable(1, c10, "Notebook Dell - Nvidia XT1090", 2944.13, new DateTime(2023, 01, 09), "");
            Receivable r2 = new Receivable(2, c1, "PlayStation 5 + God War + 2 Controllers + Headset PS Gold", 2164.17, new DateTime(2022, 01, 14), "");
            Receivable r3 = new Receivable(3, c6, "License Windows 11 - Home Basic", 645.36, new DateTime(2023, 01, 03), "");
            Receivable r4 = new Receivable(4, c9, "TV 55 Full HD - Sony", 1493.84, new DateTime(2022, 12, 21), "");
            Receivable r5 = new Receivable(5, c4, "TV 71 8K - Panasonic + Support TV", 1946.14, new DateTime(2022, 08, 19), "");
            Receivable r6 = new Receivable(6, c5, "Xbox Series X + 12 months Live Gold", 1806.34, new DateTime(2023, 01, 11), "");
            _context.AddRange(r1, r2, r3, r4, r5, r6);

            // Execution saving data
            _context.SaveChanges();
        }
    }
}
