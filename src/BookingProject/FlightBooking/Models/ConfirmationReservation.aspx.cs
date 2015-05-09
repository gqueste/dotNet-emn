using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking.Models
{
    public partial class ConfirmationReservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Routing.needRedirect(this, Routing.State.CONFIRMATION_RESERVATION))
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
                lblCompagnie.Text = vol.companie;
                lblDateVol.Text = vol.dateVol.ToShortDateString();
                lblDuree.Text = vol.duree + " heures";
                lblVilleDepart.Text = vol.villeDepart;
                lblVilleArrivee.Text = vol.villeArrivee;

                // Client :
                var client = commande.Client;
                lblNomClient.Text = client.Nom;
                lblPrenomClient.Text = client.Prenom;
                lblEmailClient.Text = client.Email;

                // Hotel :
                var hotel = commande.Hotel;
                lblNomHotel.Text = hotel.nomHotel;
                lblDescriptionHotel.Text = hotel.descriptionHotel;
                lblVilleHotel.Text = hotel.ville;
            }
        }

        protected void btnNouvelleReservation_Click(object sender, EventArgs e)
        {
            var commande = FlightBookingContext.get(this).Commande = null;
            Response.Redirect(Routing.getStateUrl(Routing.State.SAISIE_DEMANDE), true);
        }
    }
}