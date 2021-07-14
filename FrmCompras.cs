
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;




namespace Pantallas_proyecto
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
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

        private void label4_Click(object sender, EventArgs e)
        {

        }



        ClsConexionBD conect2 = new ClsConexionBD();
        Productos producto = new Productos();




        SqlDataAdapter da;
        DataTable dt;
        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------

    
        public void cargarDatosCompras(DataGridView dgv, string nombreTabla)//Metodo cargar dato compras
        {
            try
            {
                da = new SqlDataAdapter("Select  Compras.codigo_compra Codigo, Proveedores.nombre_proveedor Proveedor , fecha_compra Fecha , Metodo_Pago.descripcion_pago Pago From " + nombreTabla +
                    ", Detalle_Compra, Proveedores, Metodo_Pago Where (Compras.codigo_compra= Detalle_Compra.codigo_compra ) and (Detalle_Compra.codigo_proveedor=Proveedores.codigo_proveedor) and" +
                    "(Detalle_Compra.codigo_pago= Metodo_pago.codigo_pago );", conect2.conexion);
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
            timer1.Enabled = true;
            conect2.abrir();
            // cargarDatosProductos(dgvProductos, "Productos");
            cargarDatosCompras(dgvProveedores, "Compras");


            //Llenar Combobox Categoria Productos

            //try
            //{
            //    SqlCommand comando = new SqlCommand("SELECT codigo_categoria,descripcion_categoria FROM Categoria_Producto", conect2.conexion);

            //    conect2.abrir();
            //    SqlDataReader registro = comando.ExecuteReader();
            //    while (registro.Read())


            //    {
            //        comboBox1.Items.Add(registro["descripcion_categoria"].ToString());

            //    }
            //    conect2.cerrar();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //------------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------------------------------------------------------


            //metodo para cargar datos en combobox pago 

            try
            {
                SqlCommand comando = new SqlCommand("SELECT descripcion_pago FROM Metodo_Pago", conect2.conexion);
                conect2.abrir();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    comboPago.Items.Add(registro["descripcion_pago"].ToString());
                }
                conect2.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //metodo para cargar datos en combobox proveedores 
            try
            {
                SqlCommand comando = new SqlCommand("SELECT nombre_proveedor FROM Proveedores", conect2.conexion);
                conect2.abrir();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    comboProveedor.Items.Add(registro["nombre_proveedor"].ToString());
                }
                conect2.cerrar();

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



            //---------------------------------------------------------------------------------------------------------------------------------
            //Compras
            try
            {
                if (codigoCompra.Text == string.Empty || comboProveedor.Text == string.Empty || comboPago.Text == string.Empty || dateFecha.Text == string.Empty)
                    MessageBox.Show("Porfavor llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {


                    producto.Codigo_compra = Convert.ToInt32(codigoCompra.Text);
                    if (producto.Codigo_compra == producto.buscarCompra(codigoCompra.Text))
                    {
                        MessageBox.Show("Error el codigo de compra ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        FrmProductos produc = new FrmProductos();
                        produc.compra.Text = codigoCompra.Text;
                        produc.fecha.Text = dateFecha.Value.ToString("yyyy/MM/dd");
                        produc.proveedor.Text = comboProveedor.SelectedItem.ToString();
                        produc.pago.Text = comboPago.SelectedItem.ToString();





                        produc.Show();
                        this.Close();


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmMenuPrincipalGerente gerente = new FrmMenuPrincipalGerente();
            gerente.Show();
            this.Close();
        }


    }



}


