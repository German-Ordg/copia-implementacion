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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            security();
        }
        private void security()
        {
            var userModel = new Dominio.UserModel();
            if (userModel.securityLogin() == false)
            {
                MessageBox.Show("Error Fatal, se detectó que está intentando acceder al sistema sin credenciales, por favor inicie sesión e indentifiquese");
                Application.Exit();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmInventario menu = new FrmInventario();
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAcceso acceso = new FrmAcceso();
            acceso.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPantallaFacturacion facturacion = new frmPantallaFacturacion();
            facturacion.Show();
            this.Hide();
        }
    }
}
