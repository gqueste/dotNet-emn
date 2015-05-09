using FlightBooking.Booking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightBooking.ServiceVols;

namespace FlightBooking
{
    public partial class Travel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Routing.needRedirect(this, Routing.State.SAISIE_DEMANDE))
            {
                Response.Redirect(Routing.getRedirect(this), true);
            }
            else if (!this.IsPostBack)
            {
                ServiceVols.WSVols serVols = new ServiceVols.WSVols();
                var villesDepart = serVols.getVillesDepart();
                var villesArrivee = serVols.getVillesArrivee();

                this.lstBoxVilleDepart.DataSource = villesDepart;
                this.lstBoxVilleDepart.DataBind();

                this.lstBoxVilleArrivee.DataSource = villesArrivee;
                this.lstBoxVilleArrivee.DataBind();

                this.calendarDateDepart.SelectedDate = this.calendarDateDepart.TodaysDate;
                this.calendarDateDepart.DataBind();
            }
        }

        protected void selectionChanged(object sender, EventArgs e)
        {
            DateTime date = calendarDateDepart.SelectedDate ;
            String depart = lstBoxVilleDepart.SelectedValue;
            String arrivee = lstBoxVilleArrivee.SelectedValue;

            this.lblChoixDate.Text = "Date : " + date.ToString("dd/MM/yyyy");
            this.lblChoixDepart.Text = (!String.IsNullOrEmpty(depart) ? "Départ : " + depart : "");
            this.lblChoixArrivee.Text = (!String.IsNullOrEmpty(arrivee) ? "Arrivée : " + arrivee : "");
            
            if (!String.IsNullOrEmpty(depart) && !String.IsNullOrEmpty(arrivee))
            {
                this.btnConfirmer.Visible = true;
            }
        }

        protected void btnConfirmer_Click(object sender, EventArgs e)
        {
            var demande = new DemandeVol()
            {
                DateDepart = calendarDateDepart.SelectedDate,
                VilleDepart = lstBoxVilleDepart.SelectedValue,
                VilleArrivee = lstBoxVilleArrivee.SelectedValue
            };

            var commande = new Commande() 
            { 
                Demande = demande
            };

            FlightBookingContext.get(this).Commande = commande;

            Response.Redirect(Routing.getStateUrl(Routing.State.SELECTION_VOL), true);
        }

    }
}