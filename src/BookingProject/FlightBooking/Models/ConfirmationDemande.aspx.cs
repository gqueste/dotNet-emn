using FlightBooking.Booking;
using FlightBooking.ServiceVols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking.Models
{
    public partial class Confirmation : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Routing.needRedirect(this, Routing.State.CONFIRMATION_DEMANDE))
            {
                Response.Redirect(Routing.getRedirect(this), true);
            }
            else
            {
                var commande = FlightBookingContext.get(this).Commande;

                // Vol :
                var vol = commande.Vol;
                lblIdVol.Text = vol.idVol.ToString();
                lblNomVol.Text = vol.nomVol;
                lblCompagnie.Text = vol.compagnie;
                lblDateVol.Text = vol.dateVol.ToShortDateString();
                lblDuree.Text = vol.duree + " heures";
                lblVilleDepart.Text = vol.villeDepart;
                lblVilleArrivee.Text = vol.villeArrivee;

                // Hotel :
                var hotel = commande.Hotel;
                lblNomHotel.Text = hotel.nomHotel;
                lblDescriptionHotel.Text = hotel.descriptionHotel;
                lblVilleHotel.Text = hotel.ville;
            }
        }

        protected void btnModifierVol_Click(object sender, EventArgs e)
        {
            FlightBookingContext.get(this).Commande.Vol = null;
            Response.Redirect(Routing.getStateUrl(Routing.State.SELECTION_VOL), true);
        }

        protected void btnModifierHotel_Click(object sender, EventArgs e)
        {
            FlightBookingContext.get(this).Commande.Hotel = null;
            Response.Redirect(Routing.getStateUrl(Routing.State.SELECTION_HOTEL), true);
        }

        protected void btnAnnuler_Click(object sender, EventArgs e)
        {
            FlightBookingContext.get(this).Commande = null;
            Response.Redirect(Routing.getStateUrl(Routing.State.SAISIE_DEMANDE), true);
        }

        protected void btnConfirmer_Click(object sender, EventArgs e)
        {
            var commande = FlightBookingContext.get(this).Commande;
            commande.Confirmee = true;

            Response.Redirect(Routing.getStateUrl(Routing.State.PAIEMENT), true);
        }

    }

}