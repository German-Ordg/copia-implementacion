
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace Pantallas_proyecto
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        ClsConexionBD conect = new ClsConexionBD();
        Productos producto = new Productos();


        SqlDataAdapter da;
        DataTable dt;
        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------

        public void cargarDatosProductos(DataGridView dgv, string nombreTabla)//Metodo cargar dato productos
        {
            try
            {
                da = new SqlDataAdapter("Select codigo_producto Codigo,Categoria_Producto.descripcion_categoria Categoria, descripcion_producto Descripcion, cantidad_existente Cantidad,precio_actual , descuento_producto Descuento , talla  " +
                    "From " + nombreTabla + ", Categoria_Producto Where Categoria_Producto.codigo_categoria = Productos.codigo_categoria ", conect.conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------
        public void cargarDatosCompras(DataGridView dgv, string nombreTabla)//Metodo cargar dato compras
        {
            try
            {
                da = new SqlDataAdapter("Select  Compras.codigo_compra Codigo, Proveedores.codigo_Proveedor Proveedor , fecha_compra Fecha , codigo_pago Pago From " + nombreTabla +
                    ", Detalle_Compra, Proveedores Where (Compras.codigo_compra= Detalle_Compra.codigo_compra )and Detalle_Compra.codigo_proveedor=Proveedores.codigo_proveedor ;", conect.conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------
        private void FrmCompras_Load(object sender, EventArgs e)
        {

            conect.abrir();
            cargarDatosProductos(dataGridView1, "Productos");
            cargarDatosCompras(dataGridView2, "Compras");


            //Llenar Combobox Categoria Productos

            try
            {
                SqlCommand comando = new SqlCommand("SELECT codigo_categoria,descripcion_categoria FROM Categoria_Producto", conect.conexion);

                conect.abrir();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())


                {
                    comboBox1.Items.Add(registro["descripcion_categoria"].ToString());

                }
                conect.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //------------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------------------------------


            //metodo para cargar datos en combobox pago 

            try
            {
                SqlCommand comando = new SqlCommand("SELECT codigo_pago FROM Metodo_Pago", conect.conexion);
                conect.abrir();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    comboBox2.Items.Add(registro["codigo_pago"].ToString());
                }
                conect.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipalGerente acceso = new FrmMenuPrincipalGerente();
            acceso.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       

        private void button2_Click_2(object sender, EventArgs e)
        {
            producto.Codigo_producto = Convert.ToInt32(codigoProducto.Text);
            producto.Descripcion = descripcionProducto.Text;
            producto.Cantidad = Convert.ToInt32(cantidad.Text);
            producto.Precio_actual = Convert.ToDouble(precioActual.Text);
            producto.Descuento = Convert.ToDouble(descuento.Text);
            producto.Talla = talla.Text;
            producto.Descripcion_Categoria = comboBox1.SelectedItem.ToString();
            producto.Categoria = Convert.ToInt32(producto.buscar(producto.Descripcion_Categoria));
            producto.agregar();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


