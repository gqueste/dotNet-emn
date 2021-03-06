﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace lib_Vols
{
    public class clsVols : ServicedComponent
    {
        private string Connection = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=VOLS;Integrated Security=True";

        [AutoComplete]
        public List<resVol> getVolsDisponibles(String villeDepart, String villeArrivee, DateTime date)
        {
            List<resVol> ret = new List<resVol>();

            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = Connection;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_vols_dispos", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Parameters.Add("@VILLE_DEPART", SqlDbType.VarChar);
            MyCommand.Parameters["@VILLE_DEPART"].Value = villeDepart;
            MyCommand.Parameters.Add("@VILLE_ARRIVEE", SqlDbType.VarChar);
            MyCommand.Parameters["@VILLE_ARRIVEE"].Value = villeArrivee;
            MyCommand.Parameters.Add("@DATE", SqlDbType.DateTime);
            MyCommand.Parameters["@DATE"].Value = date;

            SqlDataReader reader = MyCommand.ExecuteReader();
            while (reader.Read())
            {
                resVol oneVol = new resVol();
                oneVol.idVol = reader.GetInt32(0);
                oneVol.nomVol = reader.GetString(1);
                oneVol.compagnie = reader.GetString(2);
                oneVol.dateVol = reader.GetDateTime(3);
                oneVol.duree = reader.GetDouble(4);
                oneVol.villeDepart = reader.GetString(5);
                oneVol.villeArrivee = reader.GetString(6);
                ret.Add(oneVol);
            }
            MyConnection.Close();
            return (ret);
        }

        [AutoComplete]
        public resVol getVol(int idVol)
        {
            resVol ret = new resVol();

            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = Connection;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_vol_byId", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;
            MyCommand.Parameters.Add("@ID_VOL", SqlDbType.Int);
            MyCommand.Parameters["@ID_VOL"].Value = idVol;

            SqlDataReader reader = MyCommand.ExecuteReader();
            while (reader.Read())
            {
                ret.idVol = reader.GetInt32(0);
                ret.nomVol = reader.GetString(1);
                ret.compagnie = reader.GetString(2);
                ret.dateVol = reader.GetDateTime(3);
                ret.duree = reader.GetDouble(4);
                ret.villeDepart = reader.GetString(5);
                ret.villeArrivee = reader.GetString(6);
            }
            MyConnection.Close();
            return (ret);
        }

        [AutoComplete]
        public List<String> getVillesDepart()
        {
            List<String> ret = new List<String>();

            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = Connection;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_villesDepart", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = MyCommand.ExecuteReader();
            while (reader.Read())
            {
                ret.Add(reader.GetString(0));
            }
            MyConnection.Close();
            return (ret);
        }

        [AutoComplete]
        public List<String> getVillesArrivee()
        {
            List<String> ret = new List<String>();

            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = Connection;
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand("sp_villesArrivee", MyConnection);
            MyCommand.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = MyCommand.ExecuteReader();
            while (reader.Read())
            {
                ret.Add(reader.GetString(0));
            }
            MyConnection.Close();
            return (ret);
        }

    }

    public class resVol : ServicedComponent{
        public int idVol;
        public String nomVol;
        public String compagnie;
        public DateTime dateVol;
        public double duree;
        public String villeDepart;
        public String villeArrivee;
    }
}
