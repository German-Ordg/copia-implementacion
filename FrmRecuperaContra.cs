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
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAcceso acceso = new FrmAcceso();
            acceso.Show();
            this.Hide();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            txtresultado.Visible = true;
            var user = new Dominio.UserModel();
            var result = user.recoverPassword(cmbUsuariorequerido.Text);
            txtresultado.Text = result;
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
                MessageBox.Show("Error al buscar el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conect.cerrar();
        }
    }
}
