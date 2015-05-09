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
                //TODO: Placer ici le code à executer au chargement de la page
            }
        }

        protected void btnNouvelleReservation_Click(object sender, EventArgs e)
        {
            var commande = FlightBookingContext.get(this).Commande = null;
            Response.Redirect(Routing.getStateUrl(Routing.State.SAISIE_DEMANDE), true);
        }
    }
}