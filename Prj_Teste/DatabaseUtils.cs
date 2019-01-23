using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace prjManut
{
    class DatabaseUtils
    {
        public MySqlConnection Conn { get; set; }

        public DatabaseUtils()
        {
            Conn = new MySqlConnection("server=mysql995.umbler.com;user id=manut;persistsecurityinfo=True;port=41890;database=bdli;SslMode=none");
        }

        public void AbrirConexao()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
        }

        public void FecharConexao()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public MySqlDataReader ExecuteDataReader(string query)
        {
            try
            {
                var comm = new MySqlCommand(query, Conn);
                comm.CommandType = CommandType.Text;
                MySqlDataReader reader = comm.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public MySqlDataReader ExecuteDataReader(string query, params MySqlParameter[] parameters)
        {
            try
            {
                var comm = new MySqlCommand(query, Conn);
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddRange(parameters);
                MySqlDataReader reader = comm.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            try
            {
                AbrirConexao();
                using (var comm = new MySqlCommand(query, Conn))
                {
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.AddRange(parameters);

                    comm.ExecuteNonQuery();
                    FecharConexao();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
