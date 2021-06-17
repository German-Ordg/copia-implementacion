using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pantallas_proyecto
{
    public partial class frmPantallaFacturacion : Form
    {
        public frmPantallaFacturacion()
        {
            InitializeComponent();
        }

        SqlCommand sql;
        ClsConexionBD con = new ClsConexionBD();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void frmPantallaFacturacion_Load(object sender, EventArgs e)
        {
            con.abrir();
            
        }
    }
}
