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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipalGerente gerente = new FrmMenuPrincipalGerente();
            gerente.Show();
            this.Close();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet.Categoria_Producto' Puede moverla o quitarla según sea necesario.
            this.categoria_ProductoTableAdapter.Fill(this.db_a75e9e_bderickmoncadaDataSet.Categoria_Producto);


            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            switch (CBtipo.Text)
            {
                case "Categoria":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab1"];
                  

                    break;
                case "Lo mas vendido":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab2"];

                    break;
                case "Productos a punto de acabarse":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab3"];

                    break;
                case "Talla que mas se vende":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab4"];

                    break;
                case "Rotacion del inventario":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab5"];

                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
