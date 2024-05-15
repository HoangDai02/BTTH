using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {}
        public DbSet<Person> Person { get; set; }
    }
}