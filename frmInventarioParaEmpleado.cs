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
using System.Data.Sql;


namespace Pantallas_proyecto
{
    public partial class frmInventarioParaEmpleado : Form
    {
        private bool letra1 = false;
        private bool letra2 = false;
        private bool letra3 = false;
        private bool numero1 = false;

        public frmInventarioParaEmpleado()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;
        validaciones validacion = new validaciones();


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //FrmInventario_Gerente menu = new FrmInventario_Gerente();
         //   menu.Show();
            this.Close();
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            int poc;

            poc = dataGridView1.CurrentRow.Index;

            textBox1.Text = dataGridView1[0, poc].Value.ToString();
            comboBox2.Text = dataGridView1[1, poc].Value.ToString();
        }*/

        private void frmInventarioParaEmpleado_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            textBox2.Enabled = false;
           
           
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var aux = new MetodoBuscarCodigo();
           // aux.filtrar1(textBox2.Text, this.textBox1.Text.Trim());
        }
        FrmInventario_Gerente fact = new FrmInventario_Gerente();


        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                conect.cerrar();
                conect.abrir();
                cmd = new SqlCommand("Update Productos set codigo_categoria = '"+comboBox2.Text+"', descripcion_producto = '" + textBox2.Text + "'Where codigo_producto = "+ textBox1.Text, conect.conexion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se Ha actualizado Correctamente");
                conect.cerrar();

                FrmInventario_Gerente fact = new FrmInventario_Gerente();
                fact.Show();
                this.Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validacion.Espacio_Blanco(ErrorProvider, textBox1) || validacion.Solo_Numeros(ErrorProvider, textBox1))
            {
                if (validacion.Espacio_Blanco(ErrorProvider, textBox1))
                    ErrorProvider.SetError(textBox1, "no se puede dejar en blanco");
                else
                if (validacion.Solo_Letras(ErrorProvider, textBox1))
                    ErrorProvider.SetError(textBox1, "Solo se permite numeros");
            }
            else
            {
                numero1 = true;
            }
            if (numero1)
            {

                conect.abrir();
                cmd = new SqlCommand("select * from Productos where codigo_producto = @codigo_producto ", conect.conexion);
                cmd.Parameters.AddWithValue("@codigo_producto", textBox1.Text);
                SqlDataReader Productos = cmd.ExecuteReader();
                if (Productos.Read())
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox2.Text = Productos["codigo_categoria"].ToString();
                    textBox2.Text = Productos["descripcion_producto"].ToString();
                }
                else
                {
                    MessageBox.Show("Error al buscar producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                conect.cerrar();

            }
        }
    }
}
