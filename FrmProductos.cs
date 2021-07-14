
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Pantallas_proyecto
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {

            InitializeComponent();

        }


        ClsConexionBD conect2 = new ClsConexionBD();
        Productos producto = new Productos();
        FrmCompras compras = new FrmCompras();



        SqlDataAdapter da;
        DataTable dt;


        private void label2_Click(object sender, EventArgs e)
        {

        }





        public void cargarDatosProductos(DataGridView dgv, string nombreTabla)//Metodo cargar dato productos
        {
            try
            {
                da = new SqlDataAdapter("Select codigo_producto Codigo,Categoria_Producto.descripcion_categoria Categoria, descripcion_producto Descripcion, cantidad_existente Cantidad,precio_actual Precio , descuento_producto Descuento , talla  " +
                    "From " + nombreTabla + ", Categoria_Producto Where Categoria_Producto.codigo_categoria = Productos.codigo_categoria ", conect2.conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }




   


        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (codigoProducto.Text == string.Empty || descripcionProducto.Text == string.Empty || comboBox1.Text == string.Empty || precioCompra.Text == string.Empty || precioActual.Text == string.Empty || cantidad.Text == string.Empty || descuento.Text == string.Empty)
                    MessageBox.Show("Porfavor llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    producto.Codigo_producto = Convert.ToInt32(codigoProducto.Text);

                    if (producto.buscarProducto(codigoProducto.Text) != producto.Codigo_producto)
                    {
                        producto.Codigo_producto = Convert.ToInt32(codigoProducto.Text);
                        producto.Descripcion = descripcionProducto.Text;
                        producto.Cantidad = Convert.ToInt32(cantidad.Text);
                        producto.Precio_actual = Convert.ToDouble(precioActual.Text);
                        producto.Descuento = Convert.ToDouble(descuento.Text);
                        producto.Talla = talla.Text;
                        producto.Descripcion_Categoria = comboBox1.SelectedItem.ToString();
                        producto.Categoria = Convert.ToInt32(producto.buscarCategoria(producto.Descripcion_Categoria));
                        producto.agregarProducto();
                        cargarDatosProductos(dgvProductos, "Productos");






                    }
                    else
                        if (producto.buscarProducto(codigoProducto.Text) == producto.Codigo_producto)
                    {


                        producto.Codigo_producto = Convert.ToInt32(codigoProducto.Text);


                        int cant = producto.buscarProducto2(codigoProducto.Text);

                        producto.Cantidad = Convert.ToInt32(cantidad.Text) + cant;
                        producto.Precio_actual = Convert.ToDouble(precioActual.Text);
                        producto.Descuento = Convert.ToDouble(descuento.Text);

                        producto.actualizarProducto();
                        cargarDatosProductos(dgvProductos, "Productos");


                    }

                    //producto.Descripcion_proveedor = comboProveedor.SelectedItem.ToString();
                    //   producto.Codigo_proveedor = producto.buscarProveedor(producto.Descripcion_proveedor);
                    //  producto.Descripcion_pago = comboPago.SelectedItem.ToString();
                    // producto.Codigo_pago = producto.buscarPago(producto.Descripcion_pago);
                    producto.Cantidad_compra = Convert.ToInt32(cantidad.Text);
                    producto.Precio_compra = Convert.ToDouble(precioCompra.Text);

                    //
                    producto.Codigo_compra = Convert.ToInt32(compra.Text);
                    producto.Descripcion_fecha = fecha.Text;
                    producto.Descripcion_proveedor = proveedor.Text;
                    producto.Codigo_proveedor = producto.buscarProveedor(producto.Descripcion_proveedor);
                    producto.Descripcion_pago = pago.Text;
                    producto.Codigo_pago = producto.buscarPago(producto.Descripcion_pago);


                    producto.agregarCompra();
                    producto.agregarDetalleCompra();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            codigoProducto.Clear();
            descripcionProducto.Clear();
            cantidad.Clear();
            precioActual.Clear();
            descuento.Clear();
            talla.Clear();
            comboBox1.Items.Clear();
            descripcionProducto.Clear();
            precioCompra.Clear();

            
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            cargarDatosProductos(dgvProductos, "Productos");
            try
            {
                SqlCommand comando = new SqlCommand("SELECT codigo_categoria,descripcion_categoria FROM Categoria_Producto", conect2.conexion);

                conect2.abrir();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())


                {
                    comboBox1.Items.Add(registro["descripcion_categoria"].ToString());

                }
                conect2.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCompras fact = new FrmCompras();
            fact.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {

            comboBox1.Enabled = false;
            descripcionProducto.Enabled = false;
            codigoProducto.Enabled = false;
            talla.Enabled = false;
            comboBox1.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            codigoProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            descripcionProducto.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            precioActual.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            descuento.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            talla.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2_events();


        }


        private void comboBox2_events()
        {
            int selection = comboBox2.SelectedIndex;
            if (selection == -1)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                if (selection == 0)
                {
                    textBox1.Enabled = true;
                    textBox2.Enabled = false;
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                    textBox1.Clear();
                    textBox2.Clear();

                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var aux = new Buscar_CodigoFrmProductos();
            aux.filtrar1(dgvProductos, this.textBox2.Text.Trim());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var aux = new MetodoBuscarDescripcion();
            aux.filtrar(dgvProductos, this.textBox1.Text.Trim());
        }
    }
}

