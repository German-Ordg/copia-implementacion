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
    public partial class FrmMenuCRUD : Form
    {
        public FrmMenuCRUD()
        {
            InitializeComponent();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipalGerente principalGerente = new FrmMenuPrincipalGerente();
            principalGerente.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleados = new FrmEmpleados();
            empleados.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProveedores proveedores = new frmProveedores();
            proveedores.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMetodosdePago metodosdePago = new FrmMetodosdePago();
            metodosdePago.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmPuestosTrabajo trabajo = new frmPuestosTrabajo();
            trabajo.Show();
            this.Close();
        }
    }
}
