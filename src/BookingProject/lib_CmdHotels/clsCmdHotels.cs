using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace lib_CmdHotels
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsCmdHotels: ServicedComponent
    {
        private string Connection = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=CMDHOTELS;Integrated Security=True";
        [AutoComplete]
        public void reserveHotel(int idHotel, DateTime date, String nomUtilisateur)
        {
            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = Connection;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_reservation_hotel", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Parameters.Add("@ID_HOTEL", SqlDbType.VarChar);
            MyCommand.Parameters["@ID_HOTEL"].Value = idHotel;
            MyCommand.Parameters.Add("@DATE", SqlDbType.DateTime);
            MyCommand.Parameters["@DATE"].Value = date;
            MyCommand.Parameters.Add("@NOM_UTILISATEUR", SqlDbType.VarChar);
            MyCommand.Parameters["@NOM_UTILISATEUR"].Value = nomUtilisateur;

            MyCommand.ExecuteScalar();
            MyConnection.Close();
        }
    }
}
