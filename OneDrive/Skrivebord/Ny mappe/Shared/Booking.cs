using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sheltermini.Shared
{
    public class Booking
    {
        public Booking(Shelter shelter)
        {
            this.Shelter = shelter;
        }
        public Shelter Shelter { get; set;}
        public string Startdate { get; set;}
        public string Slutdate { get; set;}
        public int NumberOfPeople { get; set; }
        public int BookingId { get; set; }
        public string ShelterId { get; set; }
        public string FullName { get; set;} = "";
        public string Email { get; set;}
     public string Phone { get; set;}
    }
}
