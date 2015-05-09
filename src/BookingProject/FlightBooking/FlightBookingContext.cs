using FlightBooking.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;

namespace FlightBooking
{
    public class FlightBookingContext
    {
        public HttpSessionState Session { get; set; }

        private FlightBookingContext() { }

        public static FlightBookingContext get(Page page)
        {
            return new FlightBookingContext() { Session = page.Session };
        }

        public static FlightBookingContext get(MasterPage page)
        {
            return new FlightBookingContext() { Session = page.Session };
        }

        public Commande Commande
        {
            get
            {
                return Session["commande"] as Commande;
            }

            set
            {
                if (value == null)
                {
                    Session.Remove("commande");
                }
                else
                {
                    Session["commande"] = value;
                }
                
            }
        }

        public Client Client
        {
            get
            {
                return Session["client"] as Client;
            }

            set
            {
                if (value == null)
                {
                    Session.Remove("client");
                }
                else
                {
                    Session["client"] = value;
                }
            }
        }

    }
}