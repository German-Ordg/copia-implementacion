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
using Microsoft.Reporting.WinForms;

namespace Pantallas_proyecto
{
    public partial class frmPantallaFacturacion : Form
    {
        public frmPantallaFacturacion()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        SqlCommand cmd;
        SqlDataReader dr;

        ClsConexionBD con = new ClsConexionBD();
        ClsClientes clie = new ClsClientes();
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

        

        private void button8_Click(object sender, EventArgs e)
        {
            if (Cashe.UserCache.Position == "Vendedor")
            {
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.Show();
                this.Close();
            }
            if (Cashe.UserCache.Position == "Gerente")
            {
                FrmMenuPrincipalGerente menu = new FrmMenuPrincipalGerente();
                menu.Show();
                this.Close();
            }
            
        }
        //German
       
        private void frmPantallaFacturacion_Load(object sender, EventArgs e)
        {
                                 
            con.abrir();
            fac.cargarComboboxPago(cmbTipoPago);
            fac.cargarComboboxVendedor(cmbVendedor);
            rbSinNombre.Checked = true;
            btnCalcularFactura.Enabled = false;
            btnImprimirFactura.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminarTodo.Enabled = false;
            timer1.Enabled = true;
            

            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double sumaTotales=0;
            double subTotal;
            double descuentos=0;
            double isv;
            double total;
            btnImprimirFactura.Enabled = true;

            foreach (DataGridViewRow row in lstCompras.Rows)
            {
                if (row.Cells[5].Value != null)
                    sumaTotales += (Double)double.Parse(row.Cells[5].Value.ToString());
            }

            foreach (DataGridViewRow row in lstCompras.Rows)
            {
                if (row.Cells[4].Value != null)
                    descuentos += (Double)double.Parse(row.Cells[4].Value.ToString());
            }
                  
            subTotal = sumaTotales - descuentos;

            isv = (subTotal) * 0.15;

            total = subTotal + isv;

            txtDescuentosOtorgados.Text = descuentos.ToString();
            txtTotalPagar.Text = total.ToString();
            txtISV15.Text = isv.ToString();
            txtSubTotal.Text = subTotal.ToString();
            

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
                    btnAgregar.Enabled = true;
                    
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
                if (nudCantidad.Value > 0)
                {
                    btnEliminar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminarTodo.Enabled = true;
                    btnCalcularFactura.Enabled = true;

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

                    txtCodProducto.Clear();
                    txtDescripcion.Clear();
                    txtDescuento.Clear();
                    txtPrecioUnitario.Clear();
                    nudCantidad.Value = 1;
                    btnAgregar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Ingrese un número válido en la cantidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("No hay suficiente cantidad en el inventario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void lstCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void editar(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstCompras.CurrentRow != null)
            {
                if (lstCompras.CurrentRow.Index != lstCompras.RowCount - 1)
                {
                    txtCodProducto.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    btnEditar.Enabled = false;
                    btnActualizar.Enabled = true;

                    int a = lstCompras.CurrentRow.Index;
                    txtCodProducto.Text = lstCompras.Rows[a].Cells[0].Value.ToString();
                    nudCantidad.Value = Int32.Parse(lstCompras.Rows[a].Cells[1].Value.ToString());
                    txtDescripcion.Text = lstCompras.Rows[a].Cells[2].Value.ToString();
                    txtPrecioUnitario.Text = lstCompras.Rows[a].Cells[3].Value.ToString();
                    txtDescuento.Text = lstCompras.Rows[a].Cells[4].Value.ToString();
                    lstCompras.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se puede ediar esta fila", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value <= fac.CantidadInventario)
            {

                int n = lstCompras.CurrentRow.Index;

                lstCompras.Rows[n].Cells[0].Value = fac.CodigoProducto.ToString();
                lstCompras.Rows[n].Cells[1].Value = nudCantidad.Value.ToString();
                lstCompras.Rows[n].Cells[2].Value = fac.DescripcionProducto.ToString();
                lstCompras.Rows[n].Cells[3].Value = fac.PrecioProducto.ToString();
                lstCompras.Rows[n].Cells[4].Value = fac.DescuentoProducto.ToString();

                double total = Int32.Parse(nudCantidad.Value.ToString()) * fac.PrecioProducto;
                lstCompras.Rows[n].Cells[5].Value = total.ToString();
                lstCompras.Enabled = true;
                btnAgregar.Enabled = true;

                txtCodProducto.Clear();
                txtDescripcion.Clear();
                txtDescuento.Clear();
                txtPrecioUnitario.Clear();
                nudCantidad.Value = 1;
            }
            else
            {
                MessageBox.Show("No hay suficiente cantidad en el inventario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCompras.SelectedRows.Count != 0)
            {
                if(lstCompras.CurrentRow.Index != lstCompras.RowCount - 1)
                {
                    lstCompras.Rows.RemoveAt(lstCompras.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar esta fila", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("No ha seleccionado un ítem a borrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if(txtRTN.Text.Length!=0)
            {

                String consultaRTN = "select [nombre_cliente], [apellido_cliente], [rtn] from [dbo].[Clientes] where [rtn] = "+txtRTN.Text;


                con.abrir();
                try
                {
                    cmd = new SqlCommand(consultaRTN, con.conexion);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        clie.NombreCliente = dr["nombre_cliente"].ToString();
                        clie.ApellidoCliente = dr["apellido_cliente"].ToString();
                        clie.Rtn = dr["rtn"].ToString();
                        
                    }
                    dr.Close();

                    MessageBox.Show("Nombre del cliente: "+clie.NombreCliente+" "+clie.ApellidoCliente, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.cerrar();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No ha encontrado el cliente en la base de datos" + ex.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                MessageBox.Show("Ingrese un RTN", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            if (lstCompras.DataSource is DataTable)
            {
                lstCompras.Rows.Clear();
                lstCompras.Refresh();
            }
        }
        
        
         
        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            List<impresion> impresion = new List<impresion>();
            ReportParameter[] parameters = new ReportParameter[7];
            // this.reportes.SelectedTab = reportes.TabPages["tabPage2"];
            string impuesto = txtISV15.Text;
            string importe = "100";
            string subtotal = txtSubTotal.Text;
            string total = txtTotalPagar.Text;
            string fecha = dtFecha.Text;
            string rtn = txtRTN.Text;
            string cliente = cmbVendedor.Text;
            parameters[0] = new ReportParameter("impuesto", impuesto);
            parameters[1] = new ReportParameter("importe", importe);
            parameters[2] = new ReportParameter("subtotal", subtotal);
            parameters[3] = new ReportParameter("total", total);
            parameters[4] = new ReportParameter("cliente", cliente);
            parameters[5] = new ReportParameter("rtn", rtn);
            parameters[6] = new ReportParameter("fecha", fecha);
            reportViewer1.LocalReport.SetParameters(parameters);
             
            impresion.Clear();

            for (int i = 0; i < lstCompras.Rows.Count - 1; i++)
            {
                impresion imp = new impresion();
                imp.cod_producto = (string)this.lstCompras.Rows[i].Cells[0].Value;
                imp.cantidad = (string)this.lstCompras.Rows[i].Cells[1].Value;
                imp.descripcion = (string)this.lstCompras.Rows[i].Cells[2].Value;
                imp.precio = (string)this.lstCompras.Rows[i].Cells[3].Value;
                imp.descuento = (string)this.lstCompras.Rows[i].Cells[4].Value;
                imp.total = (string)this.lstCompras.Rows[i].Cells[5].Value;
                // });
                impresion.Add(imp);
                
            }

            reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", impresion));
                this.reportViewer1.RefreshReport();
            
        }
    
    }
    public  class impresion
    {
        public string cod_producto { get; set; }
        public string cantidad { get; set; }
        public string descripcion { get; set; }
        public string precio { get; set; }
        public string descuento { get; set; }
        public string total { get; set; }
    }
}
