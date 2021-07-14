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
    class MetodoBucasrProducto
    {

        ClsConexionBD conect = new ClsConexionBD();

        public void filtrar(DataGridView data, string buscarcategoria)
        {


            try
            {
                conect.cerrar();
                conect.abrir();
                SqlCommand sql = new SqlCommand("BusquedaProducto1", conect.conexion);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@filtro", SqlDbType.VarChar, 200).Value = buscarcategoria;
               

                sql.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(dt);
                data.DataSource = dt;
                conect.cerrar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("error es: " + ex.ToString());
            }

        }
        private void datos(int categoria, string descripcion)
        {
            try
            {
                 conect.abrir();
                 SqlCommand cmd = new SqlCommand("SELECT codigo_producto, descripcion FROM Productos  WHERE codigo_categoria = @cod_categoria AND descripcion = @DESCRIPCION", conect.conexion);
                 cmd.Parameters.AddWithValue("cod_categoria", categoria);
                 cmd.Parameters.AddWithValue("descripcion", descripcion);
                 SqlDataAdapter sda = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 sda.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

