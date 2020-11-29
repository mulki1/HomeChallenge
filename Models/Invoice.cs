using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChallenge.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public DateTime InvoiceDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime SettleDate { get; set; }

        public Guid VatId { get; set; }
        public Vat Vat { get; set; }
        public Guid CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public Guid  ClientId { get; set; }
        public Client Client { get; set; }


        public string OrderId { get; set; }

        public string SaleAgent { get; set; }

    }
}
