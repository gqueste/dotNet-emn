using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using lib_Vols;

namespace serviceVols
{
    /// <summary>
    /// Description résumée de WSVols
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WSVols : System.Web.Services.WebService
    {
        private clsVols vols;

        public WSVols()
        {
            this.vols = new clsVols();

        }

        [WebMethod]
        public List<resVol> getVolsDisponibles(string villeDepart, string villeArrivee, DateTime date)
        {

            return this.vols.getVolsDisponibles(villeDepart, villeArrivee, date);
        }

        [WebMethod]
        public resVol getVol(int idVol)
        {
            return this.vols.getVol(idVol);
        }

        [WebMethod]
        public List<string> getVillesDepart()
        {
            return this.vols.getVillesDepart();
        }

        [WebMethod]
        public List<string> getVillesArrivee()
        {
            return this.vols.getVillesArrivee();
        }
    }
}
