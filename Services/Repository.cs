using HomeChallenge.Data;
using HomeChallenge.Models;
using System;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace HomeChallenge.Services
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddInvoice(Invoice invoice)
        {
            try
            {
                var result = await  _dbContext.Invoices.AddAsync(invoice);
                _dbContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Invoice> GetInvoice (DateTime date)
        {
            try
            {
                var invoices = _dbContext.Invoices.Include(c => c.Currency).Include(v => v.Vat).Include(cl => cl.Client).FirstOrDefault(i => i.InvoiceDate == date);
                return invoices;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<Currency> GetCurrencies()
        {
            try
            {
                var currencies = _dbContext.Currencies.ToList();
                return currencies;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public List<Vat> GetVats()
        {
            try
            {
                var Vats = _dbContext.Vats.ToList();
                return Vats;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Client> GetClients()
        {
            try
            {
                var clients = _dbContext.Clients.ToList();
                return clients;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




    }
}
