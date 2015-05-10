using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using lib_CmdVols;
using lib_CmdHotels;

namespace lib_Commandes
{
    
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsCommandes: ServicedComponent
    {

        [AutoComplete]
        public void reservation(int idVol, int idHotel, DateTime date, String nomUtilisateur)
        {
            reserveVol(idVol, date, nomUtilisateur);
            reserveHotel(idHotel, date, nomUtilisateur);
        }

        private void reserveVol(int idVol, DateTime date, String nomUtilisateur)
        {
            clsCmdVols cmdVols = new clsCmdVols();
            cmdVols.reserveVol(idVol, date, nomUtilisateur);
        }

        private void reserveHotel(int idHotel, DateTime date, String nomUtilisateur)
        {
            clsCmdHotels cmdHotels = new clsCmdHotels();
            cmdHotels.reserveHotel(idHotel, date, nomUtilisateur);
        }
    }

    public class ReservationInfo
    {
        public String ID_VOL { get; set; }
        public String ID_HOTEL { get; set; }
        public String DATE { get; set; }
        public String NOM_UTILISATEUR { get; set; }
    }
}
