using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_proyecto
{
    public partial class FrmClientes : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;

        ClsConexionBD con = new ClsConexionBD();



        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmPantallaFacturacion fac = new frmPantallaFacturacion();
            fac.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            

        }
    }
}
