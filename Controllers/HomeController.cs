using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeChallenge.Models;
using HomeChallenge.Services;
using HomeChallenge.Dtos;

namespace HomeChallenge.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var dropdown = new DropDownDtos()
            {
                Currencies = _repository.GetCurrencies(),
                Vats = _repository.GetVats(),
                Clients = _repository.GetClients(),
            };
            return View(dropdown);
        }

        [HttpPost]
        public async Task<IActionResult> AddInvoice(Invoice invoice)
        {
            try
            {
                var result = await _repository.AddInvoice(invoice);
                if (result)
                {
                    return Json(new
                    {
                        Status = true,
                        Message = "Invoice Successfully Added!",
                    });
                }

                //something is wrong if the execution get here

                return Json(new
                {
                    Status = false,
                    Message = "An error occured adding invoice, please again!",
                });

            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = false,
                    Message = ex.InnerException.Message.ToString()
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> SearchInvoice(InvoiceDate invoiceDate)
        {
            try
            {
                var result = await _repository.GetInvoice(invoiceDate.date);
                return Json(new
                {
                    Status = true,
                    Invoice = result,
                });

            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Status = false,
                    Message = ex.InnerException.Message.ToString()
                });
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
