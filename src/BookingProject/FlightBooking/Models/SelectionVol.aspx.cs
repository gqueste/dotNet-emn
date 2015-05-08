using FlightBooking.Booking;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking.Models
{
    public partial class SelectionVol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DemandeVol demande = Session["demandeVol"] as DemandeVol;

            if (demande != null)
            {
                lblDemandeDate.Text = demande.dateDepart.ToShortDateString();
                lblVilleDepart.Text = demande.villeDepart;
                lblVilleArrivee.Text = demande.villeArrivee;
                lblDemandeDate.Visible = true;
                lblVilleDepart.Visible = true;
                lblVilleArrivee.Visible = true;
            }

            Vol v1 = new Vol()
            {
                idVol = 1,
                nomVol = "AirFrance classe eco bla bla",
                companie = "AirFrance",
                dateVol = DateTime.Now,
                duree = 3.5,
                villeDepart = "Paris",
                villeArrivee = "New York"
            };

            Vol v2 = new Vol()
            {
                idVol = 2,
                nomVol = "AirFrance premiere classe",
                companie = "AirFrance",
                dateVol = DateTime.Now.AddHours(2.0),
                duree = 3.5,
                villeDepart = "Paris",
                villeArrivee = "New York"
            };

            Vol v3 = new Vol()
            {
                idVol = 3,
                nomVol = "AirFrance eazy dotNet",
                companie = "AirFrance",
                dateVol = DateTime.Now.AddHours(5.0),
                duree = 3.5,
                villeDepart = "Paris",
                villeArrivee = "New York"
            };

            List<Vol> vols = new List<Vol>();
            vols.Add(v1);
            vols.Add(v2);
            vols.Add(v3);
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