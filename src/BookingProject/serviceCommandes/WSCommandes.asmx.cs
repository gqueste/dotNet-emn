using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using lib_Commandes;

namespace serviceCommandes
{
    /// <summary>
    /// Description résumée de WSCommandes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCommandes : System.Web.Services.WebService
    {

        private clsCommandes commandes;

        public WSCommandes()
        {
            this.commandes = new clsCommandes();
        }

        [WebMethod]
        public void reservation(int idVol, int idHotel, DateTime date, string nomUtilisateur)
        {
            this.commandes.reservation(idVol,idHotel,date,nomUtilisateur);
        }
    }
}
