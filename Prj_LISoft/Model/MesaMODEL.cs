using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjManut.Entidades;
using MySql.Data.MySqlClient;

namespace prjManut.Model
{
    class MesaMODEL
    {
        private DatabaseUtils dbUtils;

        public MesaMODEL()
        {
            dbUtils = new DatabaseUtils();
        }

        public List<Mesa> GetAll()
        {
            string query = "SELECT * FROM tbMesa";
            List<Mesa> listMesa = new List<Mesa>();

            try
            {
                dbUtils.AbrirConexao();
                MySqlDataReader reader = dbUtils.ExecuteDataReader(query);

                while(reader.Read())
                {
                    Mesa mesa = new Mesa();

                    mesa.CodMesa = int.Parse(reader["codMesa"].ToString());
                    mesa.CodMesa = int.Parse(reader["codAluno"].ToString());
                    mesa.HrRetirada = DateTime.Parse(reader["hrRetirada"].ToString());
                    mesa.HrEntrega = DateTime.Parse(reader["hrEntrega"].ToString());

                    listMesa.Add(mesa);
                }
                reader.Close();
                dbUtils.FecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dbUtils.FecharConexao();
            }

            return listMesa;
        }

        public void Insert(Mesa mesa)
        {
            try
            {
                string query = "INSERT INTO tbMesa(codAluno, hrRetirada) VALUES(@codAluno, @hrRetirada)";
                dbUtils.ExecuteNonQuery(query, new MySqlParameter("@codAluno", mesa.CodAluno),
                                               new MySqlParameter("@hrRetirada", mesa.HrRetirada));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dbUtils.FecharConexao();
            }
        }

        public void Update(Mesa mesa)
        {
            try
            {
                string query = "UPDATE tbMesa SET hrEntrega = @hrEntrega WHERE codMesa = @codMesa";
                dbUtils.ExecuteNonQuery(query, new MySqlParameter("@hrEntrega", mesa.HrEntrega),
                                               new MySqlParameter("@codMesa", mesa.CodMesa));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dbUtils.FecharConexao();
            }
        }
    }
}
