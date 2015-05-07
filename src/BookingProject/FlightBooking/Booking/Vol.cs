using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightBooking.Booking
{

    public class Vol
    {
        public int idVol { get; set; }

        public String nomVol { get; set; }

        public String companie { get; set; }

        public DateTime dateVol { get; set; }

        public double duree { get; set; }

        public String villeDepart { get; set; }

        public String villeArrivee { get; set; } 
    }
}