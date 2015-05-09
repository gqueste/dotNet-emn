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

                this.ListBox1.DataSource = villesDepart;
                this.ListBox1.SelectedIndex = 0;
                this.ListBox1.DataBind();

                this.ListBox2.DataSource = villesArrivee;
                this.ListBox2.SelectedIndex = 1;
                this.ListBox2.DataBind();

                this.Calendar.SelectedDate = this.Calendar.TodaysDate;
                this.Calendar.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.ListBox2.DataBind();
            this.ListBox1.DataBind();
            String depart = ListBox1.SelectedValue;
            String arrivee = ListBox2.SelectedValue;
            DateTime date = Calendar.SelectedDate;

            this.Label1.Text = "Vous avez choisi : " + depart + " - " + arrivee + "(" + date.ToString("dd/MM/yyyy") + ")";
            this.Label1.Visible = true;
            this.btnConfirmer.Visible = true;
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            this.Calendar.SelectedDate = ((Calendar)sender).SelectedDate;
        }

        protected void btnConfirmer_Click(object sender, EventArgs e)
        {
            var demande = new DemandeVol()
            {
                DateDepart = Calendar.SelectedDate,
                VilleDepart = ListBox1.SelectedValue,
                VilleArrivee = ListBox2.SelectedValue
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