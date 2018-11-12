using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CT
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                //string isTest = ConfigurationManager.AppSettings["isTest"].ToString();
                string connectionString = ConfigurationManager.ConnectionStrings["UserConectionString"].ConnectionString;
                sqlConnection.ConnectionString = connectionString;

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "select * from users";

                SqlDataReader reader = sqlCommand.ExecuteReader();

                
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string login = reader["login"].ToString();
                    string password = reader["password"].ToString();
                    //DateTime? updateDate = null;
                    //if (reader["updateDateTime"] != null)
                    //{
                    //    updateDate = DateTime.Parse(reader["updateDateTime"].ToString());
                    //}
                }

                reader.Close();

                //sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            }
            
        }
    }
}
