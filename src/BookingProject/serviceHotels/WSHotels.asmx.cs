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
        private lib_Hotels.clsHotels hotels;

        public WSHotels()
        {
            this.hotels = new lib_Hotels.clsHotels();

        }

        [WebMethod]
        public List<lib_Hotels.resHotel> getHotelsDisponibles(string ville)
        {
            return this.hotels.getHotelsDisponibles(ville);
        }

        [WebMethod]
        public lib_Hotels.resHotel getHotel(int idHotel)
        {
            return this.hotels.getHotel(idHotel);
        }
    }
}
