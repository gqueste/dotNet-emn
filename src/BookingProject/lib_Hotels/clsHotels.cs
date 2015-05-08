using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace lib_Hotels
{
    [Transaction(TransactionOption.Required), ObjectPooling(5, 10), EventTrackingEnabled(true)]
    public class clsHotels: ServicedComponent
    {
        private string Connection = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=HOTELS;Integrated Security=True";
        [AutoComplete]
        public List<resHotel> getHotelsDisponibles(String ville)
        {
            List<resHotel> ret = new List<resHotel>();

            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = Connection;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_hotels_dispos", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Parameters.Add("@VILLE", SqlDbType.VarChar);
            MyCommand.Parameters["@VILLE"].Value = ville;

            SqlDataReader reader = MyCommand.ExecuteReader();
            while (reader.Read())
            {
                resHotel oneHotel = new resHotel();
                oneHotel.idHotel = reader.GetInt32(0);
                oneHotel.nomHotel = reader.GetString(1);
                oneHotel.descriptionHotel = reader.GetString(2);
                oneHotel.ville = reader.GetString(3);
                ret.Add(oneHotel);
            }
            MyConnection.Close();
            return (ret);
        }

        [AutoComplete]
        public resHotel getHotel(int idHotel)
        {
            resHotel ret = new resHotel();

            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = Connection;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_hotel_byId", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Parameters.Add("@ID_HOTEL", SqlDbType.Int);
            MyCommand.Parameters["@ID_HOTEL"].Value = Convert.ToInt16(idHotel);

            SqlDataReader reader = MyCommand.ExecuteReader();
            while (reader.Read())
            {
                ret.idHotel = reader.GetInt32(0);
                ret.nomHotel = reader.GetString(1);
                ret.descriptionHotel = reader.GetString(2);
                ret.ville = reader.GetString(3);
            }
            MyConnection.Close();
            return (ret);
        }
    }

    public class resHotel : ServicedComponent{
        public int idHotel;
        public String nomHotel;
        public String descriptionHotel;
        public String ville;
    }
}
