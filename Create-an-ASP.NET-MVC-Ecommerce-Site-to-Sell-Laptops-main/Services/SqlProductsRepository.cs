using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Data;
using WebProject.Models;

namespace WebProject.Services
{
    public class SqlProductsRepository : IRepository<Products>
    {
        private WebProjectDbContex _context;

        public SqlProductsRepository()
        {
        }

        public SqlProductsRepository(WebProjectDbContex context)
        {
            _context = context;
        }
        public bool Add(Products item)
        {
            try
            {
                _context.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Products item)
        {
            try
            {
                Products product = Get(item.ID);
                if (product != null)
                {
                    _context.Remove(item);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Products item)
        {
            try
            {
                Products product = Get(item.ID);
                if (product != null)
                {
                    _context.Update(item);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Products Get(int id)
        {
            if (_context.product.Count(x => x.ID == id) > 0)
            {
                return _context.product.FirstOrDefault(x => x.ID == id);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Products> GetAll()
        {
            return _context.product;
        }

    }
}