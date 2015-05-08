using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightBooking
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
              //make the panel visible
              pnldynamic.Visible = chkvisible.Checked;

              //generating the lable controls:
              int n = Int32.Parse(ddllabels.SelectedItem.Value);
              for (int i = 1; i <= n; i++)
              {
                 Label lbl = new Label();
                 lbl.Text = "Label" + (i).ToString();
                 pnldynamic.Controls.Add(lbl);
                 pnldynamic.Controls.Add(new LiteralControl("<br />"));
              }
      
              //generating the text box controls:

              int m = Int32.Parse(ddltextbox.SelectedItem.Value);
              for (int i = 1; i <= m; i++)
              {
                  TextBox txt = new TextBox();
                  txt.Text = "Text Box" + (i).ToString();
                  pnldynamic.Controls.Add(txt);
                  pnldynamic.Controls.Add(new LiteralControl("<br />"));
              }

            /*DemandeVol demande = Session["demandeVol"] as DemandeVol;

            if (demande != null)
            {
                lblDemandeDate.Text = demande.dateDepart.ToShortDateString();
                lblVilleDepart.Text = demande.villeDepart;
                lblVilleArrivee.Text = demande.villeArrivee;
                lblDemandeDate.Visible = true;
                lblVilleDepart.Visible = true;
                lblVilleArrivee.Visible = true;
            }*/

        }

        protected void btntotal_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            lblpartial.Text = "Showing time from panel" + time;
            lbltotal.Text = "Showing time from outside" + time;
        }

        protected void btnpartial_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            lblpartial.Text = "Showing time from panel" + time;
            lbltotal.Text = "Showing time from outside" + time;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }
    }
}