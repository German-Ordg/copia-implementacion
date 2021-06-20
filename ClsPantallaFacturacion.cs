using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    class ClsPantallaFacturacion
    {
        ClsConexionBD con = new ClsConexionBD();

        SqlCommand cmd;
        SqlDataReader dr;


        public void cargarComboboxPago(ComboBox cmb)
        {

            String ComboboxPago = "SELECT descripcion_pago FROM [dbo].[Metodo_Pago]";
            con.abrir();
            try
            {

                cmd = new SqlCommand(ComboboxPago, con.conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr["descripcion_pago"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el combobox " + ex.ToString());
            }
            con.cerrar();
        }

        public void cargarComboboxVendedor(ComboBox cmb)
        {
            String comboboxVendedor = "SELECT [dbo].[Empleados].nombre_empleado+' '+[dbo].[Empleados].apellido_empleado nombre " +
                "FROM[dbo].[Empleados] JOIN[dbo].[Usuarios] ON [dbo].[Empleados].codigo_empelado =[dbo].[Usuarios].codigo_empleado " +
                "WHERE[dbo].[Usuarios].[Estado] = 'ACTIVO'";

            con.abrir();
            try
            {
               
                cmd = new SqlCommand(comboboxVendedor, con.conexion);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cmb.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo cargar el combobox " + ex.ToString());
            }
            con.cerrar();
        }






    }
}
