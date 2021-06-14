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
    public partial class FrmMenuPrincipalGerente : Form
    {
        public FrmMenuPrincipalGerente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmInventario_Gerente inventario_Gerente = new FrmInventario_Gerente();
            inventario_Gerente.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReportes reportes = new frmReportes();
            reportes.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPantallaFacturacion facturacion = new frmPantallaFacturacion();
            facturacion.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmCompras compras = new FrmCompras();
            compras.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMenuCRUD cRUD = new FrmMenuCRUD();
            cRUD.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAcceso acceso = new FrmAcceso();
            acceso.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
