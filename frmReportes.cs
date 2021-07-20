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

        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }

        ClsConexionBD conect = new ClsConexionBD();
        validaciones validacion = new validaciones();
        private bool letra2 = true;
        private bool letra = true;

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
        private void button7_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipalGerente gerente = new FrmMenuPrincipalGerente();
            gerente.Show();
            this.Close();
        }
        //prueba
        private void frmReportes_Load(object sender, EventArgs e)
        {
            conect.abrir();
            conect.cargarDatosreporte1(dgvcompra);
            conect.abrir();
            conect.cargarDatosreporte2(dgvrotacion);
            dgvcompra.ForeColor = Color.Black;
            dgvrotacion.ForeColor = Color.Black;
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSetrotacion.ReporteCompras' Puede moverla o quitarla según sea necesario.
            // this.reporteComprasTableAdapter2.Fill(this.db_a75e9e_bderickmoncadaDataSetrotacion.ReporteCompras);
            // TODO: esta línea de código carga datos en la tabla 'DataSetCompra_Fecha.Compra_Fecha' Puede moverla o quitarla según sea necesario.
            //this.Compra_FechaTableAdapter.Fill(this.DataSetCompra_Fecha.Compra_Fecha,Fecha1,Fecha2);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSetINVENTARIO.VCategorias' Puede moverla o quitarla según sea necesario.
            this.vCategoriasTableAdapter3.Fill(this.db_a75e9e_bderickmoncadaDataSetINVENTARIO.VCategorias);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSetFecha_Compra.ReporteCompras' Puede moverla o quitarla según sea necesario.
           // this.reporteComprasTableAdapter1.Fill(this.db_a75e9e_bderickmoncadaDataSetFecha_Compra.ReporteCompras);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet11VCategorita.VCategorias' Puede moverla o quitarla según sea necesario.
            this.vCategoriasTableAdapter2.Fill(this.db_a75e9e_bderickmoncadaDataSet11VCategorita.VCategorias);
            // TODO: esta línea de código carga datos en la tabla 'db_a75e9e_bderickmoncadaDataSet8.ReporteCompras' Puede moverla o quitarla según sea necesario.
            //this.ReporteComprasTableAdapter.Fill(this.db_a75e9e_bderickmoncadaDataSet8.ReporteCompras);
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
            if (validacion.Espacio_Blanco_CB(ErrorProvider, CBtipo))
            {
                if (validacion.Espacio_Blanco_CB(ErrorProvider, CBtipo))
                    ErrorProvider.SetError(CBtipo, "no se puede dejar en blanco");
            }
            else
            {
                letra2 = true;
            }

            if (letra2)
            {
                switch (CBtipo.Text)
                {
                    case "Categoria":
                        if (letra)
                        {
                            ReportParameter[] parameters = new ReportParameter[1];
                            this.reportes.SelectedTab = reportes.TabPages["tab1"];
                            string Categoria = CBcategoria.Text.Trim();
                            parameters[0] = new ReportParameter("Categoria", Categoria);
                            reportViewer1.LocalReport.SetParameters(parameters);
                            this.reportViewer1.RefreshReport();
                        }
                        break;
                    case "Lo mas Vendido":
                        this.reportes.SelectedTab = reportes.TabPages["tab2"];
                        this.reportViewer2.RefreshReport();
                        break;
                    case "Productos a Punto de Acabarse":
                        this.reportes.SelectedTab = reportes.TabPages["tab3"];
                        this.reportViewer3.RefreshReport();

                        break;
                    case "Talla que Mas se Vende":
                        this.reportes.SelectedTab = reportes.TabPages["tab4"];
                        this.reportViewer4.RefreshReport();
                        break;
                    case "Rotacion del Inventario":
                        List<impresion1> impresion4 = new List<impresion1>();

                        impresion4.Clear();

                        for (int i = 0; i < dgvrotacion.Rows.Count - 1; i++)
                        {
                            impresion1 imp = new impresion1();
                            imp.dato1 = this.dgvrotacion.Rows[i].Cells[0].Value.ToString();
                            imp.dato2 = (string)this.dgvrotacion.Rows[i].Cells[1].Value;
                            imp.dato3 = this.dgvrotacion.Rows[i].Cells[2].Value.ToString();
                            imp.dato4 = this.dgvrotacion.Rows[i].Cells[3].Value.ToString();
                            imp.dato5 = this.dgvrotacion.Rows[i].Cells[4].Value.ToString();
                            imp.dato6 = this.dgvrotacion.Rows[i].Cells[5].Value.ToString();
                            imp.dato7 = this.dgvrotacion.Rows[i].Cells[6].Value.ToString();
                            imp.dato8 = this.dgvrotacion.Rows[i].Cells[7].Value.ToString();
                            impresion4.Add(imp);
                        }
                        this.reportes.SelectedTab = reportes.TabPages["tab5"];
                        reportViewer5.LocalReport.DataSources.Clear();
                        reportViewer5.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", impresion4));
                        this.reportViewer5.RefreshReport();
                        break;
                    case "Inventario":
                        this.reportes.SelectedTab = reportes.TabPages["tab6"];
                        this.reportViewer6.RefreshReport();
                        break;
                    case "Compras":
                        List<impresion1> impresion = new List<impresion1>();

                        impresion.Clear();

                        for (int i = 0; i < dgvcompra.Rows.Count - 1; i++)
                        {
                            impresion1 imp = new impresion1();
                            imp.dato1 = this.dgvcompra.Rows[i].Cells[0].Value.ToString();
                            imp.dato2 = (string)this.dgvcompra.Rows[i].Cells[1].Value;
                            imp.dato3 = this.dgvcompra.Rows[i].Cells[2].Value.ToString();
                            imp.dato4 = this.dgvcompra.Rows[i].Cells[3].Value.ToString();
                            imp.dato5 = (string)this.dgvcompra.Rows[i].Cells[4].Value;
                            imp.dato6 = this.dgvcompra.Rows[i].Cells[5].Value.ToString();
                            imp.dato7 = this.dgvcompra.Rows[i].Cells[6].Value.ToString();
                            imp.dato8 = this.dgvcompra.Rows[i].Cells[7].Value.ToString();
                            impresion.Add(imp);
                        }
                        this.reportes.SelectedTab = reportes.TabPages["tab7"];
                        reportViewer8.LocalReport.DataSources.Clear();
                        reportViewer8.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", impresion));
                        this.reportViewer8.RefreshReport();
                        break;
                    case "Compras por Codigo":
                        List<impresion1> impresion2 = new List<impresion1>();

                        impresion2.Clear();

                        for (int i = 0; i < dgvcompra.Rows.Count - 1; i++)
                        {
                            impresion1 imp = new impresion1();
                            imp.dato1 = this.dgvcompra.Rows[i].Cells[0].Value.ToString();
                            imp.dato2 = (string)this.dgvcompra.Rows[i].Cells[1].Value;
                            imp.dato3 = this.dgvcompra.Rows[i].Cells[2].Value.ToString();
                            imp.dato4 = this.dgvcompra.Rows[i].Cells[3].Value.ToString();
                            imp.dato5 = (string)this.dgvcompra.Rows[i].Cells[4].Value;
                            imp.dato6 = this.dgvcompra.Rows[i].Cells[5].Value.ToString();
                            imp.dato7 = this.dgvcompra.Rows[i].Cells[6].Value.ToString();
                            imp.dato8 = this.dgvcompra.Rows[i].Cells[7].Value.ToString();
                            impresion2.Add(imp);
                        }
                        ReportParameter[] parameters1 = new ReportParameter[1];
                        this.reportes.SelectedTab = reportes.TabPages["tab8"];
                        string Codigo = txtcodigo.Text;
                        parameters1[0] = new ReportParameter("codigo", Codigo);
                        reportViewer7.LocalReport.SetParameters(parameters1);
                        reportViewer7.LocalReport.DataSources.Clear();
                        reportViewer7.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", impresion2));
                        this.reportViewer7.RefreshReport();
                        break;
                    case "Compras con Fecha":
                        List<impresion1> impresion3 = new List<impresion1>();

                        impresion3.Clear();

                        for (int i = 0; i < dgvcompra.Rows.Count - 1; i++)
                        {
                            impresion1 imp = new impresion1();
                            imp.dato1 = this.dgvcompra.Rows[i].Cells[0].Value.ToString();
                            imp.dato2 = (string)this.dgvcompra.Rows[i].Cells[1].Value;
                            imp.dato3 = this.dgvcompra.Rows[i].Cells[2].Value.ToString();
                            imp.dato4 = this.dgvcompra.Rows[i].Cells[3].Value.ToString();
                            imp.dato5 = (string)this.dgvcompra.Rows[i].Cells[4].Value;
                            imp.dato6 = this.dgvcompra.Rows[i].Cells[5].Value.ToString();
                            imp.dato7 = this.dgvcompra.Rows[i].Cells[6].Value.ToString();
                            imp.dato8 = this.dgvcompra.Rows[i].Cells[7].Value.ToString();
                            impresion3.Add(imp);
                        }
                        ReportParameter[] parameters2 = new ReportParameter[2];
                        this.reportes.SelectedTab = reportes.TabPages["tab9"];
                        string Fecha1 = dateTimePicker1.Value.ToString();
                        string Fecha2 = dateTimePicker2.Value.ToString();
                        parameters2[0] = new ReportParameter("fecha1", Fecha1);
                        parameters2[1] = new ReportParameter("fecha2", Fecha2);
                        reportViewer9.LocalReport.SetParameters(parameters2);
                        reportViewer9.LocalReport.DataSources.Clear();
                        reportViewer9.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", impresion3));
                        this.reportViewer9.RefreshReport();
                        break;
                }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtResultBox gerente = new TxtResultBox();
            gerente.Show();
            
        }
    }
    public class impresion1
    {
        public string dato1 { get; set; }
        public string dato2 { get; set; }
        public string dato3 { get; set; }
        public string dato4 { get; set; }
        public string dato5 { get; set; }
        public string dato6 { get; set; }

        public string dato7 { get; set; }

        public string dato8 { get; set; }

    }



}
