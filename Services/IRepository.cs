using HomeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChallenge.Services
{
  public interface IRepository
    {
        Task<bool> AddInvoice(Invoice invoice);

        Task<Invoice> GetInvoice(DateTime date);
        List<Currency> GetCurrencies();
        List<Vat> GetVats();
        List<Client> GetClients();
       

    }
}
