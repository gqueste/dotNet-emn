using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking
{
    public partial class FlightBooking : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool hasCommand = FlightBookingContext.get(this).Commande != null;

            this.lblPanier.Text = "Mon Panier " + (hasCommand ? "(1)" : "(0)");
        }
    }
}