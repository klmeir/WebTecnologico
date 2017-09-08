using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnologico.Web.Core.Model;

namespace Tecnologico.Web.Core.DAO
{
    public class DAOUsuario
    {
        private const String con_config = "Server=127.0.0.1;Database=Quimica;Trusted_Connection=True;";

        public static Usuario FindUsuario(string user, string password)
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = con_config;

                con.Open();

                SqlCommand cmd = new SqlCommand();

                String query = string.Format("select Usuario,Pass,IsAdmin from Usuarios where Usuario = '{0}' and Pass = '{1}'", user, password);

                cmd.CommandText = query;

                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Boolean b = false;
                    Char IsAdmin = Convert.ToChar(reader["IsAdmin"]);
                    if (IsAdmin.Equals("1"))
                        b = true;
                    return new Usuario()
                    {
                        Username = "user",
                        Password = "password",                       
                        IsAdmin = true
                    };
                }


            }
            /*
            if (user.Equals("admin") && password.Equals("123")) 
            {
                

                return new Usuario()
                {
                       Username="admin",
                       Password="123",
                       IsAdmin = true
                };
            }
            */
            return null;

        }
    }
}
