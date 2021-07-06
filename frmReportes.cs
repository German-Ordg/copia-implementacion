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
using Microsoft.Reporting.WinForms;

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
        //prueba
        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSetINVENTARIO.VCategorias' Puede moverla o quitarla según sea necesario.
            this.vCategoriasTableAdapter3.Fill(this.db_a75e9e_bderickmoncadaDataSetINVENTARIO.VCategorias);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSetFecha_Compra.ReporteCompras' Puede moverla o quitarla según sea necesario.
            this.reporteComprasTableAdapter1.Fill(this.db_a75e9e_bderickmoncadaDataSetFecha_Compra.ReporteCompras);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet11VCategorita.VCategorias' Puede moverla o quitarla según sea necesario.
            this.vCategoriasTableAdapter2.Fill(this.db_a75e9e_bderickmoncadaDataSet11VCategorita.VCategorias);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet8.ReporteCompras' Puede moverla o quitarla según sea necesario.
            this.ReporteComprasTableAdapter.Fill(this.db_a75e9e_bderickmoncadaDataSet8.ReporteCompras);
            timer1.Enabled = true;
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet5.VCategorias' Puede moverla o quitarla según sea necesario.
            this.vCategoriasTableAdapter1.Fill(this.db_a75e9e_bderickmoncadaDataSet5.VCategorias);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet4.VCategorias' Puede moverla o quitarla según sea necesario.
            this.VCategoriasTableAdapter.Fill(this.db_a75e9e_bderickmoncadaDataSet4.VCategorias);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet2.Productos' Puede moverla o quitarla según sea necesario.
            this.ProductosTableAdapter.Fill(this.db_a75e9e_bderickmoncadaDataSet2.Productos);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet.Categoria_Producto' Puede moverla o quitarla según sea necesario.
            this.categoria_ProductoTableAdapter.Fill(this.db_a75e9e_bderickmoncadaDataSet.Categoria_Producto);








        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            switch (CBtipo.Text)
            {
                case "Categoria":
                    ReportParameter[] parameters = new ReportParameter[1];
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab1"];
                    string Categoria = CBcategoria.Text.Trim();
                    parameters[0] = new ReportParameter("Categoria", Categoria);
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                    
                    

                    break;
                case "Lo mas Vendido":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab2"];
                    this.reportViewer2.RefreshReport();
                    break;
                case "Productos a Punto de Acabarse":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab3"];
                    this.reportViewer3.RefreshReport();

                    break;
                case "Talla que Mas se Vende":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab4"];
                    this.reportViewer4.RefreshReport();
                    break;
                case "Rotacion del Inventario":
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab5"];
                    this.reportViewer5.RefreshReport();
                    break;
                case "Inventario":
                        this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab6"];
                        this.reportViewer6.RefreshReport();
                    break;
                case "Compras":
                    ReportParameter[] parameters1 = new ReportParameter[1];
                    this.tabreporte1.SelectedTab = tabreporte1.TabPages["tab7"];
                    string codigo = txtcodigo.Text;
                    /*if (txtcodigo.Text != " ")
                    {

                    }
                    else
                    {*/
                        parameters1[0] = new ReportParameter("codigo", codigo);
                        reportViewer8.LocalReport.SetParameters(parameters1);
                        this.reportViewer8.RefreshReport();
                   // }


                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer6_Load(object sender, EventArgs e)
        {

        }


        private void CBcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CBtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void VCategoriasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dba75e9ebderickmoncadaDataSet2BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
