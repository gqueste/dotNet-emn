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
            DemandeVol demande = Session["demandeVol"] as DemandeVol;
            resVol vol = Session["selectionVol"] as resVol;
            Hotel hotel = Session["selectionHotel"] as Hotel;


            if (demande != null && vol != null && hotel != null)
            {
               // Vol :
                lblIdVol.Text = vol.idVol.ToString();
                lblNomVol.Text = vol.nomVol;
                lblCompanie.Text = vol.companie;
                lblDateVol.Text = vol.dateVol.ToShortDateString();
                lblDuree.Text = vol.duree + " heures";
                lblVilleDepart.Text = vol.villeDepart;
                lblVilleArrivee.Text = vol.villeArrivee;
        
                // Hotel
                lblNomHotel.Text = hotel.nomHotel;
                lblDescriptionHotel.Text = hotel.descriptionHotel;
                lblVilleHotel.Text = hotel.ville;
            }
            else
            {
                if (demande == null)
                {
                    Response.Redirect("~/Models/Travel.aspx", true);
                }
                else if (vol == null)
                {
                    Response.Redirect("~/Models/SelectionVol.aspx", true);
                }
                else if (vol == null)
                {
                    Response.Redirect("~/Models/SelectionHotel.aspx", true);
                }
            }
        }

        protected void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        protected void btnConfirmer_Click(object sender, EventArgs e)
        {

        }
    }
}