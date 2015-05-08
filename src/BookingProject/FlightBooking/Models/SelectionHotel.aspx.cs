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
    public partial class SelectionHotel : System.Web.UI.Page
    {
        List<Hotel> hotels = new List<Hotel>();

        protected void Page_Load(object sender, EventArgs e)
        {

            DemandeVol demande = Session["demandeVol"] as DemandeVol;
            resVol vol = Session["selectionVol"] as resVol;


            if (demande != null && vol != null)
            {
                lblDate.Text = demande.dateDepart.AddHours(vol.duree).ToShortDateString();
                lblVilleArrivee.Text = demande.villeArrivee;
                lblDate.Visible = true;
                lblVilleArrivee.Visible = true;
            }
            else
            {
                Response.Redirect("~/", true);
            }

            Hotel h1 = new Hotel()
            {
                idHotel = 1,
                nomHotel = "Le Nouillorquais",
                descriptionHotel = "Petit hôtel de charme",
                ville = "New-York"
            };

            Hotel h2 = new Hotel()
            {
                idHotel = 2,
                nomHotel = "RoyalHotel",
                descriptionHotel = "Luxury hotel",
                ville = "New-York"
            };

            Hotel h3 = new Hotel()
            {
                idHotel = 3,
                nomHotel = "the Average",
                descriptionHotel = "Low cost hotel",
                ville = "New-York"
            };

            hotels.Add(h1);
            hotels.Add(h2);
            hotels.Add(h3);
            GridView1.DataSource = hotels;
            GridView1.DataBind();
        }

        protected void lnkView2_Click(object sender, EventArgs e)
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;
            Hotel hotel = this.hotels[grdrow.DataItemIndex];
            Session["selectionHotel"] = hotel;
            Response.Redirect("~/Models/Confirmation.aspx");
        }
    }
}