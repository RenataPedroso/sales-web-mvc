using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;
=======
>>>>>>> parent of b3a7678 (Seller details and eager loading)
=======
>>>>>>> parent of b3a7678 (Seller details and eager loading)
=======
>>>>>>> 83b55f653ba601e95554f82ad00df5e45c0efc02

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //return all sellers
        public List<Seller> FindlAll()
        {
            return _context.Seller.ToList();
        }

        //adding object in db ç~;ç~;ç~;ç
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
<<<<<<< HEAD

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(s => s.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if(!_context.Seller.Any(s => s.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
=======
>>>>>>> 83b55f653ba601e95554f82ad00df5e45c0efc02
    }
}
