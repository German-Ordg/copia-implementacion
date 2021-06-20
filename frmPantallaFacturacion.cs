using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pantallas_proyecto
{
    public partial class frmPantallaFacturacion : Form
    {
        public frmPantallaFacturacion()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataReader dr;

        ClsConexionBD con = new ClsConexionBD();
        ClsPantallaFacturacion fac = new ClsPantallaFacturacion();


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void frmPantallaFacturacion_Load(object sender, EventArgs e)
        {
            con.abrir();
            fac.cargarComboboxPago(cmbTipoPago);
            fac.cargarComboboxVendedor(cmbVendedor);
            
        }

        private void frmPantallaFacturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
           /* if(txtCodProducto.TextLength!=0)
            {
                int codigoProducto = 

                String buscarProducto = "SELECT descripcion_producto, precio_actual, descuento_producto  " +
                    "FROM[dbo].[Productos] WHERE codigo_producto =" +;

                con.abrir();
                try
                {
                    
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un código de producto");
            }*/
        }
    }
}
