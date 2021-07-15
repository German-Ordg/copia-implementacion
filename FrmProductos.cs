
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

        string[,] productosArrays = new string[20, 8];

        int contador = 0;

        SqlDataAdapter da;
        DataTable dt;
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
                if (codigoProducto.Text == string.Empty || descripcionProducto.Text == string.Empty || cmbCategoria.Text == string.Empty || precioCompra.Text == string.Empty || precioActual.Text == string.Empty || cantidad.Text == string.Empty || descuento.Text == string.Empty)
                    MessageBox.Show("Porfavor llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);



                else
                {

                    producto.Codigo_producto = Convert.ToInt32(codigoProducto.Text);
                    producto.Precio_actual = Convert.ToInt32(precioActual.Text);
                    producto.Precio_compra = Convert.ToInt32(precioCompra.Text);
                    producto.Cantidad = Convert.ToInt32(cantidad.Text);
                    producto.Descuento = Convert.ToInt32(descuento.Text);


                    if (producto.Codigo_producto == 0 || producto.Codigo_producto <= 0)
                    {
                        MessageBox.Show("Ingrese un valor mayor a cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        codigoProducto.Clear();
                        codigoProducto.Focus();


                    }



                    else if (producto.Precio_actual == 0 || producto.Precio_actual <= 0)
                    {
                        MessageBox.Show("Ingrese un valor mayor a cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        precioActual.Clear();
                        precioActual.Focus();


                    }

                    else if (producto.Precio_compra == 0 || producto.Precio_compra <= 0)
                    {
                        MessageBox.Show("Ingrese un valor mayor a cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        precioCompra.Clear();
                        precioCompra.Focus();

                    }

                    else if (producto.Cantidad == 0 || producto.Cantidad <= 0)
                    {
                        MessageBox.Show("Ingrese un valor mayor a cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cantidad.Clear();
                        cantidad.Focus();

                    }

                    else if (producto.Descuento < 0)
                    {
                        MessageBox.Show("Ingrese un valor mayor a cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        descuento.Clear();
                        descuento.Focus();

                    }

                    else
                    {

                        productosArrays[contador, 0] = codigoProducto.Text;
                        productosArrays[contador, 1] = descripcionProducto.Text;
                        productosArrays[contador, 2] = cmbCategoria.Text;
                        productosArrays[contador, 3] = talla.Text;
                        productosArrays[contador, 4] = precioCompra.Text;
                        productosArrays[contador, 5] = precioActual.Text;
                        productosArrays[contador, 6] = cantidad.Text;
                        productosArrays[contador, 7] = descuento.Text;
                        contador++;

                        producto.Codigo_producto = Convert.ToInt32(codigoProducto.Text);
                        int RowsEscribir = dgvProductosCompra.Rows.Count - 1;
                        dgvProductosCompra.Rows.Add(1);
                        dgvProductosCompra.Rows[RowsEscribir].Cells[0].Value = codigoProducto.Text;
                        dgvProductosCompra.Rows[RowsEscribir].Cells[1].Value = descripcionProducto.Text;
                        dgvProductosCompra.Rows[RowsEscribir].Cells[2].Value = cmbCategoria.Text;
                        dgvProductosCompra.Rows[RowsEscribir].Cells[3].Value = talla.Text;
                        dgvProductosCompra.Rows[RowsEscribir].Cells[4].Value = precioCompra.Text;
                        dgvProductosCompra.Rows[RowsEscribir].Cells[5].Value = precioActual.Text;
                        dgvProductosCompra.Rows[RowsEscribir].Cells[6].Value = cantidad.Text;
                        dgvProductosCompra.Rows[RowsEscribir].Cells[7].Value = descuento.Text;

                        codigoProducto.Clear();
                        descripcionProducto.Clear();
                        cantidad.Clear();
                        precioActual.Clear();
                        descuento.Clear();
                        talla.Clear();
                        cmbCategoria.Items.Clear();
                        descripcionProducto.Clear();
                        precioCompra.Clear();
                        cmbCategoria.Enabled = true;
                        descripcionProducto.Enabled = true;
                        codigoProducto.Enabled = true;
                        talla.Enabled = true;
                        categorias();

                    }

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

          


        }

        private void categorias()
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT codigo_categoria,descripcion_categoria FROM Categoria_Producto", conect2.conexion);

                conect2.abrir();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())


                {
                    cmbCategoria.Items.Add(registro["descripcion_categoria"].ToString());

                }
                conect2.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            cargarDatosProductos(dgvProductos, "Productos");
            categorias();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Seguro que desea terminar la compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

         
                   
                    producto.Codigo_compra = Convert.ToInt32(compra.Text);
                    producto.Descripcion_fecha = fecha.Text;
                    producto.Descripcion_proveedor = proveedor.Text;
                    producto.Codigo_proveedor = producto.buscarProveedor(producto.Descripcion_proveedor);
                    producto.Descripcion_pago = pago.Text;
                    producto.Codigo_pago = producto.buscarPago(producto.Descripcion_pago);
                    producto.agregarCompra();



                    
                }


                catch (Exception)
                {

                    MessageBox.Show("Error al ingresar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                for (int u = 0; u < contador; u++)
                {
                    try
                    {
                        producto.Codigo_producto = Convert.ToInt32(productosArrays[u, 0]);

                        if (producto.buscarProducto(productosArrays[u, 0]) != producto.Codigo_producto)
                        {
                            producto.Codigo_producto = Convert.ToInt32(productosArrays[u, 0]);
                            producto.Descripcion = productosArrays[u, 1];
                            producto.Cantidad = Convert.ToInt32(productosArrays[u, 6]);
                            producto.Precio_actual = Convert.ToDouble(productosArrays[u, 5]);
                            producto.Descuento = Convert.ToDouble(productosArrays[u, 7]);
                            producto.Talla = productosArrays[u, 3];
                            producto.Descripcion_Categoria = productosArrays[u, 2];
                            producto.Categoria = Convert.ToInt32(producto.buscarCategoria(producto.Descripcion_Categoria));
                            producto.agregarProducto();
                            cargarDatosProductos(dgvProductos, "Productos");




                        }

                        else
                            if (producto.buscarProducto(productosArrays[u, 0]) == producto.Codigo_producto)
                        {


                            producto.Codigo_producto = Convert.ToInt32(productosArrays[u, 0]);


                            int cant = producto.buscarProducto2(productosArrays[u, 0]);

                            producto.Cantidad = Convert.ToInt32(productosArrays[u, 6]) + cant;
                            producto.Precio_actual = Convert.ToDouble(productosArrays[u, 5]);
                            producto.Descuento = Convert.ToDouble(productosArrays[u, 7]);

                            producto.actualizarProducto();
                            cargarDatosProductos(dgvProductos, "Productos");



                        }

                        producto.Cantidad_compra = Convert.ToInt32(productosArrays[u, 6]);
                        producto.Precio_compra = Convert.ToDouble(productosArrays[u, 4]);

                        producto.agregarDetalleCompra();
                    }


                     

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ingresar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            



            this.Close();
                FrmCompras fact = new FrmCompras();
                fact.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            cmbCategoria.Enabled = false;
            descripcionProducto.Enabled = false;
            codigoProducto.Enabled = false;
            talla.Enabled = false;
            cmbCategoria.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
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

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            FrmCompras compras = new FrmCompras();
            compras.codigoCompra.Text = compra.Text;
            compras.dateFecha.Value = Convert.ToDateTime(fecha.Text);
            compras.Show();
            this.Close();
        }

        private void cantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

