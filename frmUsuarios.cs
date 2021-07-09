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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
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

        SqlCommand scd;
        ClsConexionBD conect = new ClsConexionBD();


        private void button3_Click(object sender, EventArgs e)
        {
             try
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                if (i != -1)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al borrar datos", "ERROR...", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD CRUD = new FrmMenuCRUD();
            CRUD.Show();
            this.Hide();
        }
        
         private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("No puede ingresar datos en blanco", "Información", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    scd = new SqlCommand("Insert into Usuarios(nombre_usuario, correo_usuario, " +
                                     "contraseña_usuario, tipo_usuario)" +
                                     "Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"
                                     + textBox4.Text + "','" + comboBox1.Text + "')", conect.conexion);
                    scd.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso!", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.CargarDatosUsuario(dataGridView1);
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    comboBox1.Text = " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al ingresar datos", "ERROR...", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }
    }
}
