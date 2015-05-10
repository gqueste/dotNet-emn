using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking.Models
{
    public partial class Panier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var commande = FlightBookingContext.get(this).Commande;

            if (commande != null && commande.Demande != null)
            {
                Routing.State etat = Routing.getCurrentOrNextCommandState(this);
                lblEtatCommande.Text = this.getStateDescription(etat);
                lblVilleDepart.Text = commande.Demande.VilleDepart;
                lblVilleArrivee.Text = commande.Demande.VilleArrivee;
                showPanier(false);
            }
            else
            {
                showPanier(true);
            }
        }

        private void showPanier(bool empty)
        {
            this.pnlPanierNonVide.Visible = !empty;
            this.pnlPanierVide.Visible = empty;
        }

        private String getStateDescription(Routing.State state)
        {
            switch (state)
            {
                case Routing.State.SAISIE_DEMANDE: return "(1/6) Saisie de la demande";

                case Routing.State.SELECTION_VOL: return "(2/6) Demande saisie => Sélection d'un vol";

                case Routing.State.SELECTION_HOTEL: return "(3/6) Demande saisie => Sélection d'un hôtel";

                case Routing.State.CONFIRMATION_DEMANDE: return "(4/6) Commande saisie => Confirmation en attente";

                case Routing.State.PAIEMENT: return "(5/6) Commande confirmée => En attente de paiment";

                case Routing.State.CONFIRMATION_RESERVATION: return "(6/6) Commande réalisée, réservation confirmée";

                default: return "";
            }
        }

        protected void btnAccesCommande_Click(object sender, EventArgs e)
        {
            Response.Redirect(Routing.getStateUrl(Routing.State.SAISIE_DEMANDE), true);
        }

        protected void btnSupprimerCommande_Click(object sender, EventArgs e)
        {
            FlightBookingContext.get(this).Commande = null;
            showPanier(true);
        }
    }
}