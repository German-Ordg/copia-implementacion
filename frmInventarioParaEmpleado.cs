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
        public frmInventarioParaEmpleado()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Hide();
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
           /* ClsConexionBD conect = new ClsConexionBD();
            SqlCommand cmd;
            //conect.cargarDatosProductos(textBox2.Text);*/
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

         /*   int indice;
           // indice = textBox2.Text;
            fact.Show();
            int codigo;

            try
            {
                MetodoBucasrProducto datos = new MetodoBucasrProducto();

                if (textBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                  /*  codigo = Convert.ToInt32(textBox2.Text[0, indice].Value);
                    textBox2.Text[0, indice].Value = textBox1.Text;
                    dataGridView1[1, indice].Value = textBox2.Text;

                    cmd = new SqlCommand("UPDATE  Productos set codigo_categoria = " + textBox2.Text + " WHERE codigo_producto = " + textBox1.Text, conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El registro fue actualizado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosProductos(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }
    }
}
