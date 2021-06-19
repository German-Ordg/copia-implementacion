using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            
        }
        ClsConexionBD conex = new ClsConexionBD();
        SqlCommand cmd;
         SqlDataAdapter da;
        DataTable dt;
        DataSet DS;


        private void button7_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD menuCRUD = new FrmMenuCRUD();
            menuCRUD.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreProovedor.Text == "  " || txtTelefono.Text == "  " || txtDescripcion.Text == "  ")
                {

                    MessageBox.Show("No se pueden dejar los campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    cmd = new SqlCommand("Insert into Proovedores(codigo_proveedor, nombre_proveedor, numero_contacto, direccion_proveedor ) Values(" + txtNombreProovedor.Text + ",'" + txtTelefono.Text + "', '" + txtDescripcion.Text +  "')", conex.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los Datos con Exito ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conex.cargarDatosEmpleados(dgvProovedores);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                MessageBox.Show("ERROR AL INSERTAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
                txtNombreProovedor.Clear();
                txtTelefono.Clear();
                txtDescripcion.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt;
            DataSet DS;
            da = new SqlDataAdapter("Select * From Proveedores", conex.conexion);
            dt = new DataTable();
            da.Fill(dt);
            dgvProovedores.DataSource = dt;
        }
    }
}
