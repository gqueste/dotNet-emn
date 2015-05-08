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

        List<resVol> vols = new List<resVol>();

        protected void Page_Load(object sender, EventArgs e)
        {

            DemandeVol demande = Session["demandeVol"] as DemandeVol;
            if (demande != null)
            {
                ServiceVols.WSVols serVols = new ServiceVols.WSVols();
                vols = serVols.getVolsDisponibles(demande.villeDepart, demande.villeArrivee, demande.dateDepart).ToList<resVol>();
                lblDemandeDate.Text = demande.dateDepart.ToShortDateString();
                lblVilleDepart.Text = demande.villeDepart;
                lblVilleArrivee.Text = demande.villeArrivee;
                lblDemandeDate.Visible = true;
                lblVilleDepart.Visible = true;
                lblVilleArrivee.Visible = true;
            }
            else
            {
                Response.Redirect("~/", true);
            }

            GridView1.DataSource = vols;
            GridView1.DataBind();
        }

        protected void lnkView2_Click(object sender, EventArgs e)
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;
            resVol vol = this.vols[grdrow.DataItemIndex];
            Session["selectionVol"] = vol;
            Response.Redirect("~/Models/SelectionHotel.aspx");
        }
    }
}