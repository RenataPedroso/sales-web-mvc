using SalesWebMvc.Models;
using System.Linq;
using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //verifica se há registros na base de dados e, se não popula com os dados abaixo
        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "School");
            Department d2 = new Department(2, "Computers");
            Department d3 = new Department(3, "Books");
            Department d4 = new Department(4, "Eletronics");
            Department d5 = new Department(5, "Others");

            Seller s1 = new Seller(1, "Julia Fei", "julia-fei@gmail.com", new DateTime(1998, 4, 13), 1000.0, d2);
            Seller s2 = new Seller(2, "Lilika Duo", "lilika-duo@gmail.com", new DateTime(2002, 5, 29), 3500.0, d4);
            Seller s3 = new Seller(3, "Carlos Kue", "carlos-kue@gmail.com", new DateTime(1987, 10, 4), 2100.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 10, 28), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 09, 4), 7000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 09, 13), 4000.0, SaleStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 09, 11), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2022, 09, 14), 11000.0, SaleStatus.Pending, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 09, 7), 9000.0, SaleStatus.Billed, s1);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2022, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2022, 09, 29), 10000.0, SaleStatus.Billed, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2022, 09, 4), 3000.0, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2022, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2022, 10, 5), 2000.0, SaleStatus.Billed, s3);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2022, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2022, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2022, 10, 22), 8000.0, SaleStatus.Billed, s2);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2022, 10, 15), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2022, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2022, 10, 24), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2022, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2022, 10, 12), 8000.0, SaleStatus.Billed, s2);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2022, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2022, 10, 6), 5000.0, SaleStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4, d5);

            _context.Seller.AddRange(s1, s2, s3);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26
            );

            _context.SaveChanges();
        }
    }
}
