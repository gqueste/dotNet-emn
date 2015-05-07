using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace lib_Commandes
{
    
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsCommandes: ServicedComponent
    {
        [AutoComplete]
        public void reservation(int idVol, int idHotel, DateTime date, String nomUtilisateur)
        {
            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = "Data Source=FR-92-02-14-008;Initial Catalog=BANK_FR;Integrated Security=True";
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_reservation", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Parameters.Add("@ID_VOL", SqlDbType.VarChar);
            MyCommand.Parameters["@ID_VOL"].Value = idVol;
            MyCommand.Parameters.Add("@ID_HOTEL", SqlDbType.VarChar);
            MyCommand.Parameters["@ID_HOTEL"].Value = idHotel;
            MyCommand.Parameters.Add("@DATE", SqlDbType.DateTime);
            MyCommand.Parameters["@DATE"].Value = date;
            MyCommand.Parameters.Add("@NOM_UTILISATEUR", SqlDbType.VarChar);
            MyCommand.Parameters["@NOM_UTILISATEUR"].Value = idHotel;

            MyCommand.ExecuteScalar();
            MyConnection.Close();
        }
    }
}
