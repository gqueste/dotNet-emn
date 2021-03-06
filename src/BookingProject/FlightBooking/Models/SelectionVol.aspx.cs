﻿using FlightBooking.Booking;
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
        protected resVol[] vols;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Routing.needRedirect(this, Routing.State.SELECTION_VOL))
            {
                Response.Redirect(Routing.getRedirect(this), true);
            }
            else
            {
                var demande = FlightBookingContext.get(this).Commande.Demande;
                var serviceVols = new ServiceVols.WSVols();
              
                vols = serviceVols.getVolsDisponibles(demande.VilleDepart, demande.VilleArrivee, demande.DateDepart);
                
                lblDemandeDate.Text = demande.DateDepart.ToShortDateString();
                lblVilleDepart.Text = demande.VilleDepart;
                lblVilleArrivee.Text = demande.VilleArrivee;
                
                if (vols != null && vols.Length > 0) 
                {
                    grdViewVols.DataSource = vols;
                    grdViewVols.DataBound += (s, ev) => grdViewVols.HeaderRow.TableSection = TableRowSection.TableHeader;
                    grdViewVols.DataBind();
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
            commande.Vol = this.vols[grdrow.DataItemIndex];
        
            Response.Redirect(Routing.getStateUrl(Routing.State.SELECTION_HOTEL), true);
        }

    }
}