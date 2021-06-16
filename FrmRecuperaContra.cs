using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    public partial class FrmRecuperaContra : Form
    {
        public FrmRecuperaContra()
        {
            InitializeComponent();
        }

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
            ClsConexionBD conexionBD = new ClsConexionBD();

            conexionBD.abrir();


        }
    }
}
