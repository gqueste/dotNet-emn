using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace lib_CmdVols
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsCmdVols : ServicedComponent
    {
        private string Connection = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=CMDVOLS;Integrated Security=True";
        [AutoComplete]
        public void reserveVol(int idVol, DateTime date, String nomUtilisateur)
        {
            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = Connection;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_reservation_vol", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Parameters.Add("@ID_VOL", SqlDbType.VarChar);
            MyCommand.Parameters["@ID_VOL"].Value = idVol;
            MyCommand.Parameters.Add("@DATE", SqlDbType.DateTime);
            MyCommand.Parameters["@DATE"].Value = date;
            MyCommand.Parameters.Add("@NOM_UTILISATEUR", SqlDbType.VarChar);
            MyCommand.Parameters["@NOM_UTILISATEUR"].Value = nomUtilisateur;

            MyCommand.ExecuteScalar();
            MyConnection.Close();
        }

    }
}
