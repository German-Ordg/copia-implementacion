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
            rbSinNombre.Checked = true;
            btnBorrarProducto.Enabled = false;
            btnCalcularFactura.Enabled = false;
            btnImprimirFactura.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminarTodo.Enabled = false;
            
            
        }

        private void frmPantallaFacturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
           if(txtCodProducto.TextLength!=0)
            {
                fac.CodigoProducto = Int32.Parse(txtCodProducto.Text);
                

                String buscarProducto = "SELECT [descripcion_producto] descripcion, " +
                    "[cantidad_existente] cantidad, [precio_actual] precio, " +
                    "[descuento_producto] descuento FROM [dbo].[Productos] " +
                    "WHERE [codigo_producto]="+fac.CodigoProducto ;

                con.abrir();
                try
                {
                    
                    cmd = new SqlCommand(buscarProducto, con.conexion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fac.DescripcionProducto = dr["descripcion"].ToString();
                        fac.CantidadInventario = Int32.Parse(dr["cantidad"].ToString());
                        fac.PrecioProducto = Double.Parse(dr["precio"].ToString());
                        fac.DescuentoProducto = Double.Parse(dr["descuento"].ToString());
                    }
                    dr.Close();

                    
                    txtDescuento.Text = fac.DescuentoProducto.ToString();
                    txtPrecioUnitario.Text = fac.PrecioProducto.ToString();
                    txtDescripcion.Text = fac.DescripcionProducto;
                    btnBorrarProducto.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminarTodo.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo cargar el producto" + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un código de producto","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmClientes cli = new FrmClientes();

            cli.Show();

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
           
        }

        private void rbConNombre_CheckedChanged(object sender, EventArgs e)
        {
            lblRTN.Show();
            btnAgregarCliente.Show();
            btnBuscarCliente.Show();
            txtRTN.Show();
        }

        private void rbSinNombre_CheckedChanged(object sender, EventArgs e)
        {
            lblRTN.Hide();
            btnAgregarCliente.Hide();
            btnBuscarCliente.Hide();
            txtRTN.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(nudCantidad.Value<=fac.CantidadInventario)
            {
                fac.CantidadProducto = Int32.Parse(nudCantidad.Value.ToString());

                int indiceDataGrid = lstCompras.Rows.Count - 1;
                lstCompras.Rows.Add(1);

                double total = (fac.PrecioProducto * fac.CantidadProducto) - fac.DescuentoProducto;

                lstCompras.Rows[indiceDataGrid].Cells[0].Value = fac.CodigoProducto.ToString();
                lstCompras.Rows[indiceDataGrid].Cells[1].Value = fac.CantidadProducto.ToString();
                lstCompras.Rows[indiceDataGrid].Cells[2].Value = fac.DescripcionProducto.ToString();
                lstCompras.Rows[indiceDataGrid].Cells[3].Value = fac.PrecioProducto.ToString();
                lstCompras.Rows[indiceDataGrid].Cells[4].Value = fac.DescuentoProducto.ToString();
                lstCompras.Rows[indiceDataGrid].Cells[5].Value = total.ToString();

               

            }
            else
            {
                MessageBox.Show("No hay suficiente cantidad en el inventario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
