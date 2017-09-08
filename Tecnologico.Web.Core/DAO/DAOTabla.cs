using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnologico.Web.Core.Model;

namespace Tecnologico.Web.Core.DAO
{
    public class DAOTabla
    {
        private const String con_config = "Server=127.0.0.1;Database=Quimica;Trusted_Connection=True;";
        //private const String con_config = "Server=DESARROLLO2\\SQLEXPRESS;Database=Quimica;User Id=sa;Password=MyPassword;";



        public static List<Elemento> TodosElementos()
        {
            
            List<Elemento> lista_e = new List<Elemento>();
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = con_config;

                con.Open();

                SqlCommand cmd = new SqlCommand();

                String query = string.Format("select Numero,Simbolo,c.nombre as Categoria,e.Nombre,Grupo,Periodo,Config,Estado,Electro,Radio,Masa,Color from Elementos e inner join Categorias c on (e.Categoria = c.id) order by Periodo,Grupo");

                cmd.CommandText = query;

                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string Numero = Convert.ToString(reader["Numero"]);                                     
                    string Simbolo = Convert.ToString(reader["Simbolo"]);
                    string Categoria = Convert.ToString(reader["Categoria"]);
                    string Nombre = Convert.ToString(reader["Nombre"]);                   
                    string Grupo = Convert.ToString(reader["Grupo"]);
                    string Periodo = Convert.ToString(reader["Periodo"]);
                     string Config = Convert.ToString(reader["Config"]);                   
                    string Estado = Convert.ToString(reader["Estado"]);
                    string Electro = Convert.ToString(reader["Electro"]);
                    string Radio = Convert.ToString(reader["Radio"]);                   
                    string Masa = Convert.ToString(reader["Masa"]);
                    string Color = Convert.ToString(reader["Color"]);

                    Elemento e = new Elemento();
                    e.Numero = Numero;
                    e.Simbolo = Simbolo;
                    e.Categoria = Categoria;
                    e.Nombre = Nombre;
                    e.Grupo = Grupo;
                    e.Periodo = Periodo;
                    e.Config = Config;
                    e.Estado = Estado;
                    e.Electro = Electro;
                    e.Radio = Radio;
                    e.Masa = Masa;
                    e.Color = Color;

                    lista_e.Add(e);
                    //Console.WriteLine(e.ToString());
                }               
                

            }
            return lista_e;

        }

        public static Elemento FindElemento(string numero)
        {

            Elemento r = null;
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = con_config;

                con.Open();

                SqlCommand cmd = new SqlCommand();

                String query = string.Format("select Numero,Simbolo,c.nombre as Categoria,e.Nombre,Grupo,Periodo,Config,Estado,Electro,Radio,Masa,Color from Elementos e inner join Categorias c on (e.Categoria = c.id) where Numero = '{0}'",numero);

                cmd.CommandText = query;

                cmd.Connection = con;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    r = new Elemento();
                    string Numero = Convert.ToString(reader["Numero"]);
                    string Simbolo = Convert.ToString(reader["Simbolo"]);
                    string Categoria = Convert.ToString(reader["Categoria"]);
                    string Nombre = Convert.ToString(reader["Nombre"]);
                    string Grupo = Convert.ToString(reader["Grupo"]);
                    string Periodo = Convert.ToString(reader["Periodo"]);
                    string Config = Convert.ToString(reader["Config"]);
                    string Estado = Convert.ToString(reader["Estado"]);
                    string Electro = Convert.ToString(reader["Electro"]);
                    string Radio = Convert.ToString(reader["Radio"]);
                    string Masa = Convert.ToString(reader["Masa"]);
                    string Color = Convert.ToString(reader["Color"]);
                    
                    r.Numero = Numero;
                    r.Simbolo = Simbolo;
                    r.Categoria = Categoria;
                    r.Nombre = Nombre;
                    r.Grupo = Grupo;
                    r.Periodo = Periodo;
                    r.Config = Config;
                    r.Estado = Estado;
                    r.Electro = Electro;
                    r.Radio = Radio;
                    r.Masa = Masa;
                    r.Color = Color;    
                }


            }
            return r;

        }
    }
}
