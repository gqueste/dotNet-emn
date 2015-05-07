using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
        // Déclarer la librairie et y faire référence

        public WSVols()
        {
            // Paramètres que l'on veut dans le constructeur

        }

        [WebMethod]
        public List<string> getVolsDisponibles(string villeDepart, string villeArrivee, DateTime date)
        {
            // A voir si on met un Dataset ou si on garde la liste de strings
            // Pour que ça marche pour l'instant
            return new List<string>();
        }

        [WebMethod]
        public string getVol(int idVol)
        {
            // A voir pour le type du retour
            return "le vol demandé";
        }

        [WebMethod]
        public List<string> getVillesDepart()
        {
            return new List<string>();
        }

        [WebMethod]
        public List<string> getVillesArrivee()
        {
            return new List<string>();
        }
    }
}
