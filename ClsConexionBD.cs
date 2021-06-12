using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pantallas_proyecto
{
    public class ClsConexionBD
    {
        public SqlConnection conexion = new SqlConnection("server= .; database=HEAVEN_STORE ; integrated security = true");
        public void abrir()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " ,ex.Message);
            }
        }
        public void cerrar()
        {
            conexion.Close();
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection("server=. ; database=HEAVEN_STORE ; integrated security = true");
        }

    }
    
}
