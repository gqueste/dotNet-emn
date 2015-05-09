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
        protected Hotel[] hotels;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Routing.needRedirect(this, Routing.State.SELECTION_HOTEL))
            {
                Response.Redirect(Routing.getRedirect(this), true);
            }
            else
            {
                var vol = FlightBookingContext.get(this).Commande.Vol;
                
                // ------- CODE A DECOMENTER POUR L'INTERFACAGE (devrait fonctionner) -----
                //
                // var serviceHotels = new ServiceHotels.WSHotels();
                // hotels = serviceHotels.getHotelsDisponibles(vol.villeArrivee);
                //

                lblDate.Text = vol.dateVol.AddHours(vol.duree).ToShortDateString();
                lblVilleArrivee.Text = vol.villeArrivee;

                // ---------- DEBUT CODE A SUPPRIMER QUAND INTERFACAGE REALISE ----------

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
                hotels = new Hotel[] { h1, h2, h3 };

                // --------------- FIN CODE A SUPPRIMER ----------------------------------

                if (hotels != null && hotels.Length > 0)
                {
                    grdViewHotels.DataSource = hotels;
                    grdViewHotels.DataBound += (s, ev) => grdViewHotels.HeaderRow.TableSection = TableRowSection.TableHeader;
                    grdViewHotels.DataBind();
                }
                else
                {
                    lblNoResults.Visible = true;
                    btnNouvelleRecherche.CssClass = "btn btn-primary";
                }
            } 
        }

        protected void btnNouvelleRecherche_Click(object sender, EventArgs e)
        {
            FlightBookingContext.get(this).Commande = null;
            Response.Redirect(Routing.getStateUrl(Routing.State.SAISIE_DEMANDE), true);
        }

        protected void lnkBtnSelection_Click(object sender, EventArgs e)
        {
            GridViewRow grdrow = (GridViewRow)((LinkButton)sender).NamingContainer;

            var commande = FlightBookingContext.get(this).Commande;
            commande.Hotel = this.hotels[grdrow.DataItemIndex];

            Response.Redirect(Routing.getStateUrl(Routing.State.CONFIRMATION_DEMANDE), true);
        }

    }
}