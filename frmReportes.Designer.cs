﻿
namespace Pantallas_proyecto
{
    partial class frmReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.btnmostrar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CBtipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBcategoria = new System.Windows.Forms.ComboBox();
            this.tab5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportes = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab6 = new System.Windows.Forms.TabPage();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab7 = new System.Windows.Forms.TabPage();
            this.reportViewer8 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tab8 = new System.Windows.Forms.TabPage();
            this.reportViewer7 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.db_a75e9e_bderickmoncadaDataSet2 = new Pantallas_proyecto.db_a75e9e_bderickmoncadaDataSet2();
            this.ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductosTableAdapter = new Pantallas_proyecto.db_a75e9e_bderickmoncadaDataSet2TableAdapters.ProductosTableAdapter();
            this.DataSetinventario = new Pantallas_proyecto.DataSetinventario();
            this.db_a75e9e_bderickmoncadaDataSetfechacompra = new Pantallas_proyecto.db_a75e9e_bderickmoncadaDataSetfechacompra();
            this.compraFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compra_FechaTableAdapter = new Pantallas_proyecto.db_a75e9e_bderickmoncadaDataSetfechacompraTableAdapters.Compra_FechaTableAdapter();
            this.tab5.SuspendLayout();
            this.tab4.SuspendLayout();
            this.tab3.SuspendLayout();
            this.tab2.SuspendLayout();
            this.reportes.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab6.SuspendLayout();
            this.tab7.SuspendLayout();
            this.tab8.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a75e9e_bderickmoncadaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetinventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a75e9e_bderickmoncadaDataSetfechacompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraFechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.Maroon;
            this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.ForeColor = System.Drawing.Color.White;
            this.btnmostrar.Location = new System.Drawing.Point(1002, 477);
            this.btnmostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(221, 53);
            this.btnmostrar.TabIndex = 58;
            this.btnmostrar.Text = "Mostrar en Pantalla";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Maroon;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1074, 26);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 32);
            this.button7.TabIndex = 59;
            this.button7.Text = "Regresar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(937, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(899, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(881, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tipo de Reporte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(903, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Fecha hasta:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(1002, 170);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(132, 22);
            this.txtcodigo.TabIndex = 66;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1002, 210);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // CBtipo
            // 
            this.CBtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtipo.FormattingEnabled = true;
            this.CBtipo.Items.AddRange(new object[] {
            "Categoria",
            "Lo mas Vendido",
            "Productos a Punto de Acabarse",
            "Talla que Mas se Vende",
            "Rotacion del Inventario",
            "Inventario",
            "Compras",
            "Compras_con_Fecha"});
            this.CBtipo.Location = new System.Drawing.Point(1002, 304);
            this.CBtipo.Margin = new System.Windows.Forms.Padding(4);
            this.CBtipo.Name = "CBtipo";
            this.CBtipo.Size = new System.Drawing.Size(225, 24);
            this.CBtipo.TabIndex = 68;
            this.CBtipo.SelectedIndexChanged += new System.EventHandler(this.CBtipo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(920, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Categoria:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CBcategoria
            // 
            this.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBcategoria.FormattingEnabled = true;
            this.CBcategoria.Location = new System.Drawing.Point(1002, 359);
            this.CBcategoria.Name = "CBcategoria";
            this.CBcategoria.Size = new System.Drawing.Size(225, 24);
            this.CBcategoria.TabIndex = 72;
            this.CBcategoria.ValueMember = "descripcion_categoria";
            this.CBcategoria.SelectedIndexChanged += new System.EventHandler(this.CBcategoria_SelectedIndexChanged);
            // 
            // tab5
            // 
            this.tab5.Controls.Add(this.reportViewer5);
            this.tab5.Location = new System.Drawing.Point(4, 25);
            this.tab5.Name = "tab5";
            this.tab5.Padding = new System.Windows.Forms.Padding(3);
            this.tab5.Size = new System.Drawing.Size(842, 461);
            this.tab5.TabIndex = 5;
            this.tab5.Text = "Reporte5";
            this.tab5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Report5.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(836, 455);
            this.reportViewer5.TabIndex = 0;
            // 
            // tab4
            // 
            this.tab4.Controls.Add(this.reportViewer4);
            this.tab4.Location = new System.Drawing.Point(4, 25);
            this.tab4.Name = "tab4";
            this.tab4.Padding = new System.Windows.Forms.Padding(3);
            this.tab4.Size = new System.Drawing.Size(842, 461);
            this.tab4.TabIndex = 4;
            this.tab4.Text = "Reporte4";
            this.tab4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(836, 455);
            this.reportViewer4.TabIndex = 0;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.reportViewer3);
            this.tab3.Location = new System.Drawing.Point(4, 25);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(842, 461);
            this.tab3.TabIndex = 3;
            this.tab3.Text = "Reporte3";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductosBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(836, 455);
            this.reportViewer3.TabIndex = 0;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.reportViewer2);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(842, 461);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Reporte2";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(836, 455);
            this.reportViewer2.TabIndex = 0;
            // 
            // reportes
            // 
            this.reportes.Controls.Add(this.tab1);
            this.reportes.Controls.Add(this.tab2);
            this.reportes.Controls.Add(this.tab3);
            this.reportes.Controls.Add(this.tab4);
            this.reportes.Controls.Add(this.tab5);
            this.reportes.Controls.Add(this.tab6);
            this.reportes.Controls.Add(this.tab7);
            this.reportes.Controls.Add(this.tab8);
            this.reportes.Location = new System.Drawing.Point(12, 96);
            this.reportes.Name = "reportes";
            this.reportes.SelectedIndex = 0;
            this.reportes.Size = new System.Drawing.Size(850, 490);
            this.reportes.TabIndex = 70;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.reportViewer1);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(842, 461);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Reporte1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetVCategorias";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(836, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // tab6
            // 
            this.tab6.Controls.Add(this.reportViewer6);
            this.tab6.Location = new System.Drawing.Point(4, 25);
            this.tab6.Name = "tab6";
            this.tab6.Padding = new System.Windows.Forms.Padding(3);
            this.tab6.Size = new System.Drawing.Size(842, 461);
            this.tab6.TabIndex = 6;
            this.tab6.Text = "Reporte6";
            this.tab6.UseVisualStyleBackColor = true;
            // 
            // reportViewer6
            // 
            reportDataSource3.Name = "DataSetVCategorias";
            this.reportViewer6.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer6.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Reportinventario.rdlc";
            this.reportViewer6.Location = new System.Drawing.Point(3, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(836, 455);
            this.reportViewer6.TabIndex = 0;
            this.reportViewer6.Load += new System.EventHandler(this.reportViewer6_Load);
            // 
            // tab7
            // 
            this.tab7.Controls.Add(this.reportViewer8);
            this.tab7.Location = new System.Drawing.Point(4, 25);
            this.tab7.Name = "tab7";
            this.tab7.Padding = new System.Windows.Forms.Padding(3);
            this.tab7.Size = new System.Drawing.Size(842, 461);
            this.tab7.TabIndex = 7;
            this.tab7.Text = "Reporte7";
            this.tab7.UseVisualStyleBackColor = true;
            // 
            // reportViewer8
            // 
            this.reportViewer8.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            this.reportViewer8.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer8.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Report8.rdlc";
            this.reportViewer8.Location = new System.Drawing.Point(3, 3);
            this.reportViewer8.Name = "reportViewer8";
            this.reportViewer8.ServerReport.BearerToken = null;
            this.reportViewer8.Size = new System.Drawing.Size(836, 455);
            this.reportViewer8.TabIndex = 0;
            // 
            // tab8
            // 
            this.tab8.Controls.Add(this.reportViewer7);
            this.tab8.Location = new System.Drawing.Point(4, 25);
            this.tab8.Name = "tab8";
            this.tab8.Padding = new System.Windows.Forms.Padding(3);
            this.tab8.Size = new System.Drawing.Size(842, 461);
            this.tab8.TabIndex = 8;
            this.tab8.Text = "Reporte8";
            this.tab8.UseVisualStyleBackColor = true;
            // 
            // reportViewer7
            // 
            this.reportViewer7.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.compraFechaBindingSource;
            this.reportViewer7.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer7.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Reportcompra_fecha.rdlc";
            this.reportViewer7.Location = new System.Drawing.Point(3, 3);
            this.reportViewer7.Name = "reportViewer7";
            this.reportViewer7.ServerReport.BearerToken = null;
            this.reportViewer7.Size = new System.Drawing.Size(836, 455);
            this.reportViewer7.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1002, 258);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker2.TabIndex = 73;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 604);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1255, 25);
            this.toolStrip1.TabIndex = 74;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantallas_proyecto.Properties.Resources.Letras1;
            this.pictureBox1.Location = new System.Drawing.Point(466, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // db_a75e9e_bderickmoncadaDataSet2
            // 
            this.db_a75e9e_bderickmoncadaDataSet2.DataSetName = "db_a75e9e_bderickmoncadaDataSet2";
            this.db_a75e9e_bderickmoncadaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductosBindingSource
            // 
            this.ProductosBindingSource.DataMember = "Productos";
            this.ProductosBindingSource.DataSource = this.db_a75e9e_bderickmoncadaDataSet2;
            // 
            // ProductosTableAdapter
            // 
            this.ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // DataSetinventario
            // 
            this.DataSetinventario.DataSetName = "DataSetinventario";
            this.DataSetinventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_a75e9e_bderickmoncadaDataSetfechacompra
            // 
            this.db_a75e9e_bderickmoncadaDataSetfechacompra.DataSetName = "db_a75e9e_bderickmoncadaDataSetfechacompra";
            this.db_a75e9e_bderickmoncadaDataSetfechacompra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraFechaBindingSource
            // 
            this.compraFechaBindingSource.DataMember = "Compra_Fecha";
            this.compraFechaBindingSource.DataSource = this.db_a75e9e_bderickmoncadaDataSetfechacompra;
            // 
            // compra_FechaTableAdapter
            // 
            this.compra_FechaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1255, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.reportes);
            this.Controls.Add(this.CBcategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBtipo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnmostrar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1273, 676);
            this.MinimumSize = new System.Drawing.Size(1273, 676);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heaven Store - Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.tab5.ResumeLayout(false);
            this.tab4.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.reportes.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab6.ResumeLayout(false);
            this.tab7.ResumeLayout(false);
            this.tab8.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a75e9e_bderickmoncadaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetinventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a75e9e_bderickmoncadaDataSetfechacompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraFechaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CBtipo;
        
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBcategoria;
        private System.Windows.Forms.TabPage tab5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.TabPage tab4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.TabPage tab3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.TabPage tab2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.TabControl reportes;
        private System.Windows.Forms.TabPage tab6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tab8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer7;
        private System.Windows.Forms.BindingSource ProductosBindingSource;
        private db_a75e9e_bderickmoncadaDataSet2 db_a75e9e_bderickmoncadaDataSet2;
        private db_a75e9e_bderickmoncadaDataSet2TableAdapters.ProductosTableAdapter ProductosTableAdapter;
        private DataSetinventario DataSetinventario;
        private System.Windows.Forms.BindingSource compraFechaBindingSource;
        private db_a75e9e_bderickmoncadaDataSetfechacompra db_a75e9e_bderickmoncadaDataSetfechacompra;
        private db_a75e9e_bderickmoncadaDataSetfechacompraTableAdapters.Compra_FechaTableAdapter compra_FechaTableAdapter;
    }
}