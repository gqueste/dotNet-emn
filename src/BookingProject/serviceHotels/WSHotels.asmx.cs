using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace serviceHotels
{
    /// <summary>
    /// Description résumée de WSHotels
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WSHotels : System.Web.Services.WebService
    {
// Déclarer la librairie et y faire référence

        public WSHotels()
        {
            // Paramètres que l'on veut dans le constructeur

        }

        [WebMethod]
        public List<string> getHotelsDisponibles(string ville)
        {
            // A voir si on met un Dataset ou si on garde la liste de strings
            // Pour que ça marche pour l'instant
            return new List<string>();
        }

        [WebMethod]
        public string getHotel(int idHotel)
        {
            // A voir pour le type du retour
            return "l'hôtel demandé";
        }
    }
}
