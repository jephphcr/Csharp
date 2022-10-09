using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Policy;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;

namespace Database
{
    public class Person
    {
        private string connString = "";

        public Person()
        {
            connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

        public int Save(string name, string cpf, string phone, string email)
        {
            int id=0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                //string sql = "INSERT INTO People (Name,CPF,Phone,Email) VALUES (@nome, @cpf, @telefone,@email) SELECT SCOPE_IDENTITY()";
                string sqlSP = "SavePerson";
                SqlCommand cmd = new SqlCommand(sqlSP, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = cpf;

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = phone;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                try
                {
                    conn.Open();
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return id;
        }

        public void Excluir(int id)
        {

        }

        public void Update(int id, string name, string cpf, string phone,  string email)
        {

            using (SqlConnection conn = new SqlConnection(connString))
            {

                string sql = "UPDATE USERS SET  Name = @nome, CPF = @cpf, Phone = @telefone ,Email = @email) WHERE id = @id ";
                //string sqlSP = "SavePerson";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;

                cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
                cmd.Parameters["@cpf"].Value = cpf;

                cmd.Parameters.Add("@phone", SqlDbType.VarChar);
                cmd.Parameters["@phone"].Value = phone;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public DataTable List(string name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                
                string sql = "select * from People";

                
                if (!string.IsNullOrEmpty(name))
                {
                    sql += " where Name like '%" + name + "%'";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                


                try
                {
                    conn.Open();
                    //id = Convert.ToInt32(cmd.ExecuteScalar());

                    using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                    {
                        a.Fill(dt);
                    }

                 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return dt;
        }

        
    }
}
