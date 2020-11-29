using HomeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeChallenge.Dtos
{
    public class DropDownDtos
    {
        public List<Currency> Currencies { get; set; }
        public List<Vat> Vats { get; set; }
        public List<Client> Clients { get; set; }
    }
}
