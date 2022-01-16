using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Reservation
    {   
        public int Id { get; set; }
        public int GuestId { get; set; }
        public int ApartmentId { get; set; }
        public decimal Payment { get; set; }
        public DateTime BeginDate { get; set; }
        public int NumberOfDays { get; set; }
        
    }
}
