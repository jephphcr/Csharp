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
    public class Adresses
    {
        private string connString = "";

        public Adresses()
        {
            connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }

       
        public DataTable List(string name)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                
                string sql = "select * from Adresses";

                
                //if (!string.IsNullOrEmpty(name))
                //{
                //    sql += " where Name like '%" + name + "%'";
                //}

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
