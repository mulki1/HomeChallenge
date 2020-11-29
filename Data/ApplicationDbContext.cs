using HomeChallenge.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChallenge.Data
{
    public class ApplicationDbContext : DbContext
    {

       public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Vat> Vats { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<ExchangeRate> ExchangeRates { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            base.OnModelCreating(builder);
 }
    }
}
