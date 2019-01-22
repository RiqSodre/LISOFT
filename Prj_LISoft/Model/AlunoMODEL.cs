using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjManut.Entidades;
using MySql.Data.MySqlClient;

namespace prjManut.Model
{
    class AlunoMODEL
    {
        private DatabaseUtils dbUtils;

        public AlunoMODEL()
        {
            dbUtils = new DatabaseUtils();    
        }

        public List<Aluno> GetAll()
        {
            string query = "SELECT * FROM tbAluno";
            List<Aluno> listAluno = new List<Aluno>();

            try
            {
                dbUtils.AbrirConexao();
                MySqlDataReader reader = dbUtils.ExecuteDataReader(query);

                while(reader.Read())
                {
                    Aluno aluno = new Aluno();

                    aluno.CodAluno = int.Parse(reader["codAluno"].ToString());
                    aluno.Biometria = uint.Parse(reader["biometria"].ToString());

                    listAluno.Add(aluno);
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

            return listAluno;
        }

        public void Insert(Aluno aluno)
        {
            try
            {
                string query = "INSERT INTO tbAluno(codAluno, biometria) VALUES(@codAluno, @biometria)";
                dbUtils.ExecuteNonQuery(query, new MySqlParameter("@codAluno", aluno.CodAluno),
                                               new MySqlParameter("@biometria", aluno.Biometria));
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

        /*public void Update(Aluno aluno)
        {
            try
            {
                string query = "UPDATE tbAluno SET codAluno = @codAluno, biometria = @biometria WHERE codAluno = @codAluno";
                dbUtils.ExecuteNonQuery(query, new MySqlParameter("@codAluno", aluno.CodAluno),
                                           new MySqlParameter("@biometria", aluno.Biometria));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dbUtils.FecharConexao();
            }
        }*/

        public void Delete(int codAluno)
        {
            try
            {
                string query = "DELETE FROM tbAluno WHERE codAluno = @codAluno";
                dbUtils.ExecuteNonQuery(query, new MySqlParameter("@codAluno", codAluno));
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















