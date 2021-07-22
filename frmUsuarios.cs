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
using System.Security.Cryptography;

namespace Pantallas_proyecto
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        SqlCommand scd;
        ClsConexionBD conect = new ClsConexionBD();

        

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


        private void button3_Click(object sender, EventArgs e)
        {
            conect.abrir();
            try
            {
                if (txtcodemp.Text == "" || txtusuario.Text == "" || txtcontra.Text == "" || txtcorreo.Text == "" || cmbtipousr.SelectedIndex == -1)
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    scd = new SqlCommand("DELETE FROM Usuarios WHERE nombre_usuario = '" + txtusuario.Text + "' ", conect.conexion);
                    scd.ExecuteNonQuery();
                    conect.CargarDatosUsuario(dataGridView1);

                    txtcodemp.Clear();
                    txtusuario.Clear();
                    txtcontra.Clear();
                    txtcorreo.Clear();
                    cmbtipousr.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al borrar datos", "ERROR", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            conect.cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD cRUD = new FrmMenuCRUD();
            cRUD.Show();
            this.Hide();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            conect.abrir();
            try
            {
                if (txtcodemp.Text == "" || txtusuario.Text == "" || txtcorreo.Text == "" || txtcontra.Text == "" || cmbtipousr.Text == "")
                {
                    MessageBox.Show("No puede ingresar datos en blanco", "Información", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    //-------------------------------encriptar contraseña
                    string contra;


                    contra = Encrypt.GetSHA256(txtcontra.Text);


                    scd = new SqlCommand("Insert into Usuarios(codigo_empleado,nombre_usuario, correo_electronico, contrasena, Estado) Values('" + txtcodemp.Text + "','" + txtusuario.Text + "','" + txtcorreo.Text + "','" + contra + "','" + cmbtipousr.Text + "')", conect.conexion);
                    //---------------------------------------
                    scd.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.CargarDatosUsuario(dataGridView1);
                    txtcodemp.Text = " ";
                    txtusuario.Text = " ";
                    txtcorreo.Text = " ";
                    txtcontra.Text = " ";
                    cmbtipousr.Text = " ";

                }
                conect.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al ingresar datos", "ERROR", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conect.abrir();
            int indice;
            String cod;
            indice = dataGridView1.CurrentRow.Index;
            try
            {
                //string contraEncrip;
                cod = dataGridView1[0, indice].Value.ToString();
                //dataGridView1[1, indice].Value = textBox5.Text;
                dataGridView1[1, indice].Value = txtusuario.Text;
                dataGridView1[3, indice].Value = txtcorreo.Text;
                //---------------------------encriptar en el data

                string contra;

                dataGridView1[2, indice].Value = Encrypt.GetSHA256(txtcontra.Text);
                //---------------------------
                dataGridView1[4, indice].Value = cmbtipousr.Text;
                contra= Encrypt.GetSHA256(txtcontra.Text);

                scd = new SqlCommand("Update Usuarios set codigo_empleado = " + txtcodemp.Text + ",   correo_electronico = '" + txtcorreo.Text + "',  contrasena = '" + contra + "', Estado = '" + cmbtipousr.Text + "' where nombre_usuario='" + txtusuario.Text + "'", conect.conexion);

                scd.ExecuteNonQuery();

                MessageBox.Show("Registro Modificado!", "AVISO", MessageBoxButtons.OK);

                conect.CargarDatosUsuario(dataGridView1);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al modificar datos", "ERROR", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            conect.cerrar();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            toolStrip1.ForeColor = Color.Black;
            toolStripLabel1.ForeColor = Color.Black;
            toolStripLabel2.ForeColor = Color.Black;
            conect.abrir();
            conect.CargarDatosUsuario(dataGridView1);
            dataGridView1.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToShortTimeString();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int poc;
            String contraencr;
            poc = dataGridView1.CurrentRow.Index;

            txtcodemp.Text = dataGridView1[0, poc].Value.ToString();
            txtusuario.Text = dataGridView1[1, poc].Value.ToString();
            txtcorreo.Text = dataGridView1[3, poc].Value.ToString();

            //------------------------------------------

            /*  contraencr = dataGridView1[2, poc].Value.ToString();
              encryptedtext = ByteConverter.GetBytes(contraencr);
              byte[] decryptedtex = Encrypt.Decryption(encryptedtext,
              RSA.ExportParameters(true), false);
              txtcontra.Text = ByteConverter.GetString(decryptedtex);
             // txtcontra.Text = contraencr; */
            //------------------------------------------
            txtcontra.Text = "";

            cmbtipousr.Text = dataGridView1[4, poc].Value.ToString();
        }
    }
}