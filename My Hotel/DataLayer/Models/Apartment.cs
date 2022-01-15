using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Apartment
    {
        public string Id { get; set; }
        public string Adress { get; set;}
        public string Type { get; set; }
        public decimal Price {get; set;}
    }
}
