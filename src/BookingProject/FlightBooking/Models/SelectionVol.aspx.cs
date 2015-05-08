using FlightBooking.Booking;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightBooking.ServiceVols;

namespace FlightBooking.Models
{
    public partial class SelectionVol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DemandeVol demande = Session["demandeVol"] as DemandeVol;
            List<resVol> vols = new List<resVol>();
            if (demande != null)
            {
                ServiceVols.WSVolsSoapClient serVols = new ServiceVols.WSVolsSoapClient();
                vols = serVols.getVolsDisponibles(demande.villeDepart, demande.villeArrivee, demande.dateDepart).ToList<resVol>();
                lblDemandeDate.Text = demande.dateDepart.ToShortDateString();
                lblVilleDepart.Text = demande.villeDepart;
                lblVilleArrivee.Text = demande.villeArrivee;
                lblDemandeDate.Visible = true;
                lblVilleDepart.Visible = true;
                lblVilleArrivee.Visible = true;
            }

            GridView1.DataSource = vols;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "VIEW")
            {
                LinkButton lnkView = (LinkButton)e.CommandSource;
                string dealId = lnkView.CommandArgument;
                this.labelChoix.Text = dealId;
            }
        }

        protected void lnkView2_Click(object sender, EventArgs e)
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;
 
            this.labelChoix.Text = grdrow.DataItemIndex.ToString();
        }
    }
}