using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Chat
{
    internal class ClassDatos
    {
        
        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
                conexion.Open(); // abrir conexion a bd
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eror al abrir conexion: " + ex.Message);
                return null;
            }
        }

        public bool prueba()
        {
            try
            {
                abrirConexion();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Eror al abrir conexion: " + ex.Message);
                return false;
            }

        }
        //el dataset ayuda a taer informacion de la 
        public DataSet consulta(string consulta)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta, abrirConexion());
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
        public bool ejecutarComando(string cmdText)
        {
            try
            {
                SqlCommand comando = new SqlCommand(cmdText, abrirConexion());
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public DataSet comandoDs(string consulta)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter comando = new SqlDataAdapter(consulta, abrirConexion());
                comando.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
