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
    public partial class FrmInventario_Gerente : Form
    {
        public FrmInventario_Gerente()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipalGerente gerente = new FrmMenuPrincipalGerente();
            gerente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice;
            indice = dataGridView1.CurrentRow.Index;
            int codigo;

            try
            {
                if (textBox1.Text == " " || textBox2.Text == " ")
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Convert.ToInt32(dataGridView1[0, indice].Value);
                    dataGridView1[0, indice].Value = textBox1.Text;
                    dataGridView1[1, indice].Value = textBox2.Text;

                    cmd = new SqlCommand("UPDATE Productos SET codigo_producto = '" + textBox1.Text + "', categoria = '" + textBox2.Text + " WHERE cododigo_progucto = " + codigo, conect.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El registro fue actualizado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosProductos(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int poc;

            poc = dataGridView1.CurrentRow.Index;

            textBox1.Text = dataGridView1[0, poc].Value.ToString();
            textBox2.Text = dataGridView1[1, poc].Value.ToString();
        }
    }
}
