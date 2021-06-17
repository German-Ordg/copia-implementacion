
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vCategoriasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.VCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CBtipo = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabreporte1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.vCategoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.categoriaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CBcategoria = new System.Windows.Forms.ComboBox();
            this.db_a75e9e_bderickmoncadaDataSet = new Pantallas_proyecto.db_a75e9e_bderickmoncadaDataSet();
            this.categoriaProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoria_ProductoTableAdapter = new Pantallas_proyecto.db_a75e9e_bderickmoncadaDataSetTableAdapters.Categoria_ProductoTableAdapter();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer6 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.vCategoriasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCategoriasBindingSource)).BeginInit();
            this.tabreporte1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vCategoriasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a75e9e_bderickmoncadaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // vCategoriasBindingSource2
            // 
            this.vCategoriasBindingSource2.DataMember = "VCategorias";
            // 
            // VCategoriasBindingSource
            // 
            this.VCategoriasBindingSource.DataMember = "VCategorias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(465, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 68);
            this.label6.TabIndex = 57;
            this.label6.Text = "HEAVEN";
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.Maroon;
            this.btnmostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.ForeColor = System.Drawing.Color.White;
            this.btnmostrar.Location = new System.Drawing.Point(901, 379);
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
            this.button7.Location = new System.Drawing.Point(1040, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 32);
            this.button7.TabIndex = 59;
            this.button7.Text = "Regresar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(901, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 53);
            this.button1.TabIndex = 60;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(884, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha de Reporte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tipo de Reporte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Tamaño de reporte:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(949, 122);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 66;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(949, 162);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // CBtipo
            // 
            this.CBtipo.FormattingEnabled = true;
            this.CBtipo.Items.AddRange(new object[] {
            "Categoria",
            "Lo mas vendido",
            "Productos a punto de acabarse",
            "Talla que mas se vende",
            "Rotacion del inventario"});
            this.CBtipo.Location = new System.Drawing.Point(949, 207);
            this.CBtipo.Margin = new System.Windows.Forms.Padding(4);
            this.CBtipo.Name = "CBtipo";
            this.CBtipo.Size = new System.Drawing.Size(225, 24);
            this.CBtipo.TabIndex = 68;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Mensual",
            "Anual",
            "Todo"});
            this.comboBox2.Location = new System.Drawing.Point(949, 260);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 24);
            this.comboBox2.TabIndex = 69;
            // 
            // tabreporte1
            // 
            this.tabreporte1.Controls.Add(this.tab1);
            this.tabreporte1.Controls.Add(this.tabPage2);
            this.tabreporte1.Controls.Add(this.tabPage1);
            this.tabreporte1.Controls.Add(this.tabPage3);
            this.tabreporte1.Controls.Add(this.tabPage4);
            this.tabreporte1.Controls.Add(this.tabPage5);
            this.tabreporte1.Location = new System.Drawing.Point(31, 69);
            this.tabreporte1.Name = "tabreporte1";
            this.tabreporte1.SelectedIndex = 0;
            this.tabreporte1.Size = new System.Drawing.Size(774, 457);
            this.tabreporte1.TabIndex = 70;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.reportViewer1);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(766, 428);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "tabPage1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.vCategoriasBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pantallas_proyecto.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 422);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(766, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(760, 422);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 428);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(766, 428);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(766, 428);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(766, 428);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // vCategoriasBindingSource1
            // 
            this.vCategoriasBindingSource1.DataMember = "VCategorias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(867, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Categoria:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // categoriaProductoBindingSource
            // 
            this.categoriaProductoBindingSource.DataMember = "Categoria_Producto";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(760, 422);
            this.reportViewer3.TabIndex = 73;
            // 
            // CBcategoria
            // 
            this.CBcategoria.DataSource = this.categoriaProductoBindingSource1;
            this.CBcategoria.DisplayMember = "descripcion_categoria";
            this.CBcategoria.FormattingEnabled = true;
            this.CBcategoria.Location = new System.Drawing.Point(949, 311);
            this.CBcategoria.Name = "CBcategoria";
            this.CBcategoria.Size = new System.Drawing.Size(225, 24);
            this.CBcategoria.TabIndex = 72;
            this.CBcategoria.ValueMember = "descripcion_categoria";
            // 
            // db_a75e9e_bderickmoncadaDataSet
            // 
            this.db_a75e9e_bderickmoncadaDataSet.DataSetName = "db_a75e9e_bderickmoncadaDataSet";
            this.db_a75e9e_bderickmoncadaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaProductoBindingSource1
            // 
            this.categoriaProductoBindingSource1.DataMember = "Categoria_Producto";
            this.categoriaProductoBindingSource1.DataSource = this.db_a75e9e_bderickmoncadaDataSet;
            // 
            // categoria_ProductoTableAdapter
            // 
            this.categoria_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(760, 422);
            this.reportViewer4.TabIndex = 0;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(760, 422);
            this.reportViewer5.TabIndex = 0;
            // 
            // reportViewer6
            // 
            this.reportViewer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer6.Location = new System.Drawing.Point(3, 3);
            this.reportViewer6.Name = "reportViewer6";
            this.reportViewer6.ServerReport.BearerToken = null;
            this.reportViewer6.Size = new System.Drawing.Size(760, 422);
            this.reportViewer6.TabIndex = 0;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1220, 554);
            this.Controls.Add(this.CBcategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabreporte1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CBtipo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportes";
            this.Text = "Heaven Store - Reportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vCategoriasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCategoriasBindingSource)).EndInit();
            this.tabreporte1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vCategoriasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_a75e9e_bderickmoncadaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CBtipo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabControl tabreporte1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VCategoriasBindingSource;
        
        
        private System.Windows.Forms.BindingSource vCategoriasBindingSource1;
       
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label5;
        
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource;
        
        private System.Windows.Forms.BindingSource vCategoriasBindingSource2;
        
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.ComboBox CBcategoria;
        private db_a75e9e_bderickmoncadaDataSet db_a75e9e_bderickmoncadaDataSet;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource1;
        private db_a75e9e_bderickmoncadaDataSetTableAdapters.Categoria_ProductoTableAdapter categoria_ProductoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer6;
    }
}