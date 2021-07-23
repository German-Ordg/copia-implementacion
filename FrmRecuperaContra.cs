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
    public partial class FrmRecuperaContra : Form
    {
        public FrmRecuperaContra()
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

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;
        SqlCommand scd;
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAcceso acceso = new FrmAcceso();
            acceso.Show();
            this.Hide();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            validaciones validacion = new validaciones();
            if (validacion.Espacio_Blanco_CB(ErrorProvider, cmbUsuariorequerido))
            {
                if (!validacion.Espacio_Blanco_CB(ErrorProvider, cmbUsuariorequerido))
                {
                    ErrorProvider.SetError(cmbUsuariorequerido, "");
                }
                ErrorProvider.SetError(cmbUsuariorequerido, "Elija un usuario para recuperar contraseña");
            }
            else
            {
                txtresultado.Visible = true;
                var user = new Dominio.UserModel();
                var result = user.recoverPassword(cmbUsuariorequerido.Text);
                txtresultado.Text = result;

                txtcodigo.Visible = true;
                lblcodigo.Visible = true;
                btnverificar.Visible = true;
                cmbUsuariorequerido.Enabled = false;
            }
        }

        private void FrmRecuperaContra_Load(object sender, EventArgs e)
        {
            txtresultado.Visible = false;
            lblcorreo.Visible = false;
            conect.abrir();
            conect.CargaDeUsuarios(cmbUsuariorequerido);
            conect.cerrar();
            


        }

        private void cmbUsuariorequerido_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conseguir Correo del usuario
            conect.abrir();
            cmd = new SqlCommand("select correo_electronico from Usuarios where nombre_usuario = @Usuario", conect.conexion);
            cmd.Parameters.AddWithValue("@Usuario", cmbUsuariorequerido.Text);
            SqlDataReader correo = cmd.ExecuteReader();
            if (correo.Read())
            {
                lblcorreo.Text = correo["correo_electronico"].ToString();
                lblcorreo.Visible = true;
            }
            else
            {
                MessageBox.Show("Error al buscar el Correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conect.cerrar();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtcodigo.Text);
            if (Cashe.UserCache.numero == valor)
            {
                lblnueva.Visible = true;
                txtContrasena.Visible = true;
                lblcodigo.Visible = false;
                txtcodigo.Visible = false;
                btnverificar.Visible = false;
                btncambiar.Visible = true;



            }
            else
            {

                MessageBox.Show("Codigo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            try
            {
                conect.abrir();
                string contra;
                contra = Encrypt.GetSHA256(txtContrasena.Text);

                scd = new SqlCommand("update Usuarios set contrasena='" + contra + "' where nombre_usuario = '" + cmbUsuariorequerido.Text + "'", conect.conexion);

                scd.ExecuteNonQuery();

                MessageBox.Show("Contraseña actualizada!", "AVISO", MessageBoxButtons.OK);
                conect.cerrar();
                lblnueva.Visible = false;
                btncambiar.Visible = false;
                txtContrasena.Visible = false;
                txtresultado.Text = "";
                txtresultado.Visible = false;
                cmbUsuariorequerido.Text = "";
                cmbUsuariorequerido.Enabled = true;
                lblcorreo.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cambiar contraseña", "ERROR", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

            }
        }
    }
}
