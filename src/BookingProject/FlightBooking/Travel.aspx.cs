using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking
{
    public partial class Travel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var villes = new List<String>();
                villes.Add("Paris");
                villes.Add("Berlin");
                villes.Add("Londre");
                villes.Add("New York");
                villes.Add("Los Angeles");
                villes.Add("Tokyo");
                villes.Add("Pekin");

                this.ListBox1.DataSource = villes;
                this.ListBox1.SelectedIndex = 0;
                this.ListBox1.DataBind();

                this.ListBox2.DataSource = villes;
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
            /*var demande = new DemandeVol() {
                dateDepart = Calendar.SelectedDate,
                villeDepart =ListBox1.SelectedValue,
                villeArrivee = ListBox2.SelectedValue
            };

            Session.Add("demandeVol", demande);
            Response.Redirect("~/Test.aspx", true);*/
        }
    }
}