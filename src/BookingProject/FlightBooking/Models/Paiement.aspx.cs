using FlightBooking.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightBooking.ServiceCommandes;

namespace FlightBooking.Models
{
    public partial class Paiement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {                        
            if (Routing.needRedirect(this, Routing.State.PAIEMENT)) {
                Response.Redirect(Routing.getRedirect(this), true);
            }
            else
            {
                var client = FlightBookingContext.get(this).Client;
                if (client != null)
                {
                    this.tbNomClient.Text = client.Nom ?? "";
                    this.tbPrenomClient.Text = client.Prenom ?? "";
                    this.tbMail.Text = client.Email ?? "";
                }
            }
        }

        protected void cbInformationsValides_CheckedChanged(object sender, EventArgs e)
        {
            btnPayer.Enabled = cbInformationsValides.Checked;
        }

        protected void btnAnnuler_Click(object sender, EventArgs e)
        {
            FlightBookingContext.get(this).Commande = null;
            Response.Redirect(Routing.getStateUrl(Routing.State.SAISIE_DEMANDE), true);
        }

        protected void btnPayer_Click(object sender, EventArgs e)
        {
            bool emptyFields = String.IsNullOrWhiteSpace(this.tbNomClient.Text) 
                               || String.IsNullOrWhiteSpace(this.tbPrenomClient.Text)
                               || String.IsNullOrWhiteSpace(this.tbMail.Text);

            if (emptyFields)
            {
                this.lblError.Visible = true;
            }
            else
            {
                var context = FlightBookingContext.get(this);

                var client = new Client()
                {
                    Nom = this.tbNomClient.Text,
                    Prenom = this.tbPrenomClient.Text,
                    Email = this.tbMail.Text
                };
                context.Client = client;

                var commande = context.Commande;
                commande.Client = client;
                commande.Payee = true;

                var serviceCommandes = new ServiceCommandes.WSCommandes();
                serviceCommandes.reservation(commande.Vol.idVol, commande.Hotel.idHotel, DateTime.Now, commande.Client.Nom + " " + commande.Client.Prenom);

                Response.Redirect(Routing.getStateUrl(Routing.State.CONFIRMATION_RESERVATION), true);
            }
        }

    }
}