using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProject.Models;

namespace WebProject.Data
{
    public class WebProjectDbContex : DbContext
    {
        public WebProjectDbContex()
        {
        }

        public WebProjectDbContex(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Products> product { get; set; }



    }
}