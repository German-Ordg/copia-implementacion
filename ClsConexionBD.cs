using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    public class ClsConexionBD
    {
        public SqlConnection conexion = new SqlConnection("Data Source = SQL5053.site4now.net; Initial Catalog = db_a75e9e_bderickmoncada; User Id = db_a75e9e_bderickmoncada_admin; Password = grp5admin");

        SqlDataAdapter da;
        DataTable dt;
        

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
            return new SqlConnection("Data Source = SQL5053.site4now.net; Initial Catalog = db_a75e9e_bderickmoncada; User Id = db_a75e9e_bderickmoncada_admin; Password = grp5admin");
        }

        public void cargarDatosEmpleados(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * From Empleados", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


     
    }
    
}
