using FlightBooking.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;

namespace FlightBooking
{
    public class Routing
    {

        public static String VIEWS_BASE_PATH = "~/Models/";

        public static String EXT = ".aspx";

        public static String ROOT = "/";


        public enum State
        {
            NONE,
            SAISIE_DEMANDE,
            SELECTION_VOL,
            SELECTION_HOTEL,
            CONFIRMATION_DEMANDE,
            PAIEMENT,
            CONFIRMATION_RESERVATION
        }
        

        public static bool needRedirect(Page currentPage, State state)
        {
            if (state == State.NONE)
            {
                return false;
            }
            else
            {
                return state != getCurrentOrNextCommandState(currentPage);
            }
        }

        public static String getRedirect(Page currentPage)
        {
            return getStateUrl(getCurrentOrNextCommandState(currentPage));
        }

        public static State getCurrentOrNextCommandState(Page currentPage)
        {
            var commande = FlightBookingContext.get(currentPage).Commande;

            if (commande == null || commande.Demande == null)
            {
                return State.SAISIE_DEMANDE;
            }
            else if (commande.Vol == null)
            {
                return State.SELECTION_VOL;
            }
            else if (commande.Hotel == null)
            {
                return State.SELECTION_HOTEL;
            }
            else if (!commande.Confirmee)
            {
                return State.CONFIRMATION_DEMANDE;
            }
            else if (!commande.Payee)
            {
                return State.PAIEMENT;
            }
            else
            {
                return State.CONFIRMATION_RESERVATION;
            }
        }

        public static String getStateUrl(State state)
        {
            switch (state)
            {
                case State.SAISIE_DEMANDE: return VIEWS_BASE_PATH + "Travel" + EXT;

                case State.SELECTION_VOL: return VIEWS_BASE_PATH + "SelectionVol" + EXT;

                case State.SELECTION_HOTEL: return VIEWS_BASE_PATH + "SelectionHotel" + EXT;

                case State.CONFIRMATION_DEMANDE: return VIEWS_BASE_PATH + "ConfirmationDemande" + EXT;

                case State.PAIEMENT: return VIEWS_BASE_PATH + "Paiement" + EXT;

                case State.CONFIRMATION_RESERVATION: return VIEWS_BASE_PATH + "ConfirmationReservation" + EXT;

                default: return ROOT;
            }
        }

        public static String path(String viewName)
        {
            if (String.IsNullOrWhiteSpace(viewName) || viewName.Replace("~", "").Equals("/"))
            {
                return ROOT;
            }
            else if (viewName.Equals("default", StringComparison.InvariantCultureIgnoreCase) || viewName.EndsWith("default.aspx"))
            {
                return ROOT;
            }
            else 
            {
                return VIEWS_BASE_PATH + (viewName.StartsWith("/") ? "" : "/") + viewName + (viewName.StartsWith(EXT) ? "" : EXT);
            }
        }
        

    }
}