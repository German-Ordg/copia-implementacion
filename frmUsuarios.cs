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
using System.Xml.Schema;

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
        validaciones validacion = new validaciones();
        private bool letra = false;

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


       

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD cRUD = new FrmMenuCRUD();
            cRUD.Show();
            this.Hide();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            conect.abrir();

            letra = false;


            if (validacion.Espacio_Blanco(errorProvider1, txtcodemp) || validacion.Solo_Numeros(errorProvider1, txtcodemp))
            {
                if (validacion.Espacio_Blanco(errorProvider1, txtcodemp))
                    errorProvider1.SetError(txtcodemp, "no se puede dejar en blanco");
                else
                    if (validacion.Solo_Numeros(errorProvider1, txtcodemp))
                    errorProvider1.SetError(txtcodemp, "solo se permite numeros");
            }
            else
            {
                letra = true;
            }

            if (letra)
            {



                try
                {
                    if (txtcodemp.Text == "" || txtusuario.Text == "" || txtcorreo.Text == "" || txtcontra.Text == "" || cmbtipousr.Text == "")
                    {
                        MessageBox.Show("No puede ingresar datos en blanco", "Información", MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);

                    }
                    else
                    {

                        scd = new SqlCommand("Insert into Usuarios(codigo_empleado,nombre_usuario, correo_electronico, contrasena, Estado) Values('" + txtcodemp.Text + "','" + txtusuario.Text + "','" + txtcorreo.Text + "','" + txtcontra.Text + "','" + cmbtipousr.Text + "')", conect.conexion);
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
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conect.abrir();
            int indice;
            String cod;
            indice = dataGridView1.CurrentRow.Index;

            letra = false;


            if (validacion.Espacio_Blanco(errorProvider1, txtcodemp) || validacion.Solo_Numeros(errorProvider1, txtcodemp))
            {
                if (validacion.Espacio_Blanco(errorProvider1, txtcodemp))
                    errorProvider1.SetError(txtcodemp, "no se puede dejar en blanco");
                else
                    if (validacion.Solo_Numeros(errorProvider1, txtcodemp))
                    errorProvider1.SetError(txtcodemp, "solo se permite numeros");
            }
            else
            {
                letra = true;
            }

            if (letra)
            {

                try
                {

                    cod = dataGridView1[0, indice].Value.ToString();
                    //dataGridView1[1, indice].Value = textBox5.Text;
                    dataGridView1[1, indice].Value = txtusuario.Text;
                    dataGridView1[3, indice].Value = txtcorreo.Text;
                    dataGridView1[2, indice].Value = txtcontra.Text;
                    dataGridView1[4, indice].Value = cmbtipousr.Text;

                    scd = new SqlCommand("Update Usuarios set codigo_empleado = " + txtcodemp.Text + ",   correo_electronico = '" + txtcorreo.Text + "',  contrasena = '" + txtcontra.Text + "', Estado = '" + cmbtipousr.Text + "' where nombre_usuario='" + txtusuario.Text + "'", conect.conexion);

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

            poc = dataGridView1.CurrentRow.Index;

            txtcodemp.Text = dataGridView1[0, poc].Value.ToString();
            txtusuario.Text = dataGridView1[1, poc].Value.ToString();
            txtcorreo.Text = dataGridView1[3, poc].Value.ToString();
            txtcontra.Text = dataGridView1[2, poc].Value.ToString();
            cmbtipousr.Text = dataGridView1[4, poc].Value.ToString();
        }

      
    }
}