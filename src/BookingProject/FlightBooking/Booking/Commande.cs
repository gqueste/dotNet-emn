using FlightBooking.ServiceVols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightBooking.Booking
{
    public class Commande
    {
        public DemandeVol Demande { get; set; }

        public resVol Vol  { get; set; }

        public Hotel Hotel { get; set; }

        public Client Client { get; set; }

        public bool Confirmee { get; set; }

        public bool Payee { get; set; }

    }
}