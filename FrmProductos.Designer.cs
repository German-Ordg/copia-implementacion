﻿
namespace Pantallas_proyecto
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.btnEndCompra = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.codigoProducto = new System.Windows.Forms.TextBox();
            this.talla = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.precioActual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.precioCompra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descripcionProducto = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvProductosCompra = new System.Windows.Forms.DataGridView();
            this.CodProductodgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciondgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriadgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talladgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompradgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVentadgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidaddgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentodgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.pago = new System.Windows.Forms.Label();
            this.proveedor = new System.Windows.Forms.Label();
            this.compra = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCompra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEndCompra
            // 
            this.btnEndCompra.BackColor = System.Drawing.Color.Maroon;
            this.btnEndCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEndCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEndCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEndCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndCompra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEndCompra.Location = new System.Drawing.Point(607, 622);
            this.btnEndCompra.Name = "btnEndCompra";
            this.btnEndCompra.Size = new System.Drawing.Size(153, 43);
            this.btnEndCompra.TabIndex = 166;
            this.btnEndCompra.Text = "Terminar compra ";
            this.btnEndCompra.UseVisualStyleBackColor = false;
            this.btnEndCompra.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(495, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 167;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(3, 16);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(623, 171);
            this.dgvProductos.TabIndex = 92;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(21, -4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 18);
            this.label14.TabIndex = 158;
            this.label14.Text = "Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.dgvProductos);
            this.groupBox3.Location = new System.Drawing.Point(39, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 190);
            this.groupBox3.TabIndex = 171;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 146;
            this.label4.Text = "Categoría:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 145;
            this.label5.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 149;
            this.label8.Text = "Talla:";
            // 
            // codigoProducto
            // 
            this.codigoProducto.Location = new System.Drawing.Point(143, 27);
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.Size = new System.Drawing.Size(134, 20);
            this.codigoProducto.TabIndex = 144;
            // 
            // talla
            // 
            this.talla.Location = new System.Drawing.Point(118, 193);
            this.talla.Name = "talla";
            this.talla.Size = new System.Drawing.Size(159, 20);
            this.talla.TabIndex = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 143;
            this.label7.Text = "Código producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(292, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 151;
            this.label9.Text = "Descuento:";
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(448, 134);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(159, 20);
            this.cantidad.TabIndex = 142;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            // 
            // descuento
            // 
            this.descuento.Location = new System.Drawing.Point(448, 196);
            this.descuento.Name = "descuento";
            this.descuento.Size = new System.Drawing.Size(159, 20);
            this.descuento.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(292, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 141;
            this.label6.Text = "Cantidad:";
            // 
            // precioActual
            // 
            this.precioActual.Location = new System.Drawing.Point(448, 79);
            this.precioActual.Name = "precioActual";
            this.precioActual.Size = new System.Drawing.Size(159, 20);
            this.precioActual.TabIndex = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 139;
            this.label1.Text = "Precio venta (und):";
            // 
            // precioCompra
            // 
            this.precioCompra.Location = new System.Drawing.Point(448, 25);
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.Size = new System.Drawing.Size(159, 20);
            this.precioCompra.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(292, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 137;
            this.label3.Text = "Precio Compra (und):";
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.Location = new System.Drawing.Point(118, 65);
            this.descripcionProducto.Multiline = true;
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.Size = new System.Drawing.Size(159, 63);
            this.descripcionProducto.TabIndex = 148;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(118, 147);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(159, 21);
            this.cmbCategoria.TabIndex = 153;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCategoria);
            this.groupBox4.Controls.Add(this.descripcionProducto);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.precioCompra);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.precioActual);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.descuento);
            this.groupBox4.Controls.Add(this.cantidad);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.talla);
            this.groupBox4.Controls.Add(this.codigoProducto);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(39, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(629, 260);
            this.groupBox4.TabIndex = 172;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(52, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 90);
            this.label2.TabIndex = 168;
            this.label2.Text = "HEAVEN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dgvProductosCompra);
            this.groupBox1.Location = new System.Drawing.Point(690, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 243);
            this.groupBox1.TabIndex = 173;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, -4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 18);
            this.label10.TabIndex = 158;
            this.label10.Text = "Productos de la compra";
            // 
            // dgvProductosCompra
            // 
            this.dgvProductosCompra.AllowUserToDeleteRows = false;
            this.dgvProductosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProductodgv,
            this.descripciondgv,
            this.categoriadgv,
            this.talladgv,
            this.PrecioCompradgv,
            this.PrecioVentadgv,
            this.Cantidaddgv,
            this.descuentodgv});
            this.dgvProductosCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductosCompra.Location = new System.Drawing.Point(3, 16);
            this.dgvProductosCompra.Name = "dgvProductosCompra";
            this.dgvProductosCompra.ReadOnly = true;
            this.dgvProductosCompra.RowHeadersWidth = 51;
            this.dgvProductosCompra.Size = new System.Drawing.Size(715, 224);
            this.dgvProductosCompra.TabIndex = 92;
            // 
            // CodProductodgv
            // 
            this.CodProductodgv.HeaderText = "Cod. Producto";
            this.CodProductodgv.Name = "CodProductodgv";
            this.CodProductodgv.ReadOnly = true;
            // 
            // descripciondgv
            // 
            this.descripciondgv.HeaderText = "Descripcion";
            this.descripciondgv.Name = "descripciondgv";
            this.descripciondgv.ReadOnly = true;
            // 
            // categoriadgv
            // 
            this.categoriadgv.HeaderText = "Categoria";
            this.categoriadgv.Name = "categoriadgv";
            this.categoriadgv.ReadOnly = true;
            // 
            // talladgv
            // 
            this.talladgv.HeaderText = "Talla";
            this.talladgv.Name = "talladgv";
            this.talladgv.ReadOnly = true;
            // 
            // PrecioCompradgv
            // 
            this.PrecioCompradgv.HeaderText = "Precio Compra";
            this.PrecioCompradgv.Name = "PrecioCompradgv";
            this.PrecioCompradgv.ReadOnly = true;
            // 
            // PrecioVentadgv
            // 
            this.PrecioVentadgv.HeaderText = "Precio Venta";
            this.PrecioVentadgv.Name = "PrecioVentadgv";
            this.PrecioVentadgv.ReadOnly = true;
            // 
            // Cantidaddgv
            // 
            this.Cantidaddgv.HeaderText = "Cantidad";
            this.Cantidaddgv.Name = "Cantidaddgv";
            this.Cantidaddgv.ReadOnly = true;
            // 
            // descuentodgv
            // 
            this.descuentodgv.HeaderText = "Descuento";
            this.descuentodgv.Name = "descuentodgv";
            this.descuentodgv.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(294, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 18);
            this.label12.TabIndex = 176;
            this.label12.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 177;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(532, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 18);
            this.label13.TabIndex = 178;
            this.label13.Text = "Código";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(594, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 179;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(39, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 18);
            this.label15.TabIndex = 180;
            this.label15.Text = "Busqueda por";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Descripcion ",
            "Codigo"});
            this.comboBox2.Location = new System.Drawing.Point(145, 109);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 181;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(714, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 32);
            this.button3.TabIndex = 182;
            this.button3.Text = "Seleccionar ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(687, 609);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 18);
            this.label16.TabIndex = 184;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.fecha);
            this.groupBox2.Controls.Add(this.pago);
            this.groupBox2.Controls.Add(this.proveedor);
            this.groupBox2.Controls.Add(this.compra);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(690, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 190);
            this.groupBox2.TabIndex = 183;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(-3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 18);
            this.label21.TabIndex = 185;
            this.label21.Text = "Detalle de la compra";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fecha.Location = new System.Drawing.Point(154, 150);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 18);
            this.fecha.TabIndex = 153;
            // 
            // pago
            // 
            this.pago.AutoSize = true;
            this.pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pago.Location = new System.Drawing.Point(155, 111);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(0, 18);
            this.pago.TabIndex = 152;
            // 
            // proveedor
            // 
            this.proveedor.AutoSize = true;
            this.proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.proveedor.Location = new System.Drawing.Point(155, 75);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(0, 18);
            this.proveedor.TabIndex = 151;
            // 
            // compra
            // 
            this.compra.AutoSize = true;
            this.compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compra.Location = new System.Drawing.Point(155, 36);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(0, 18);
            this.compra.TabIndex = 150;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(16, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 18);
            this.label17.TabIndex = 149;
            this.label17.Text = "Método pago:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(16, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 18);
            this.label18.TabIndex = 87;
            this.label18.Text = "Código compra:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(16, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 18);
            this.label19.TabIndex = 83;
            this.label19.Text = "Proveedor:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(16, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 18);
            this.label20.TabIndex = 85;
            this.label20.Text = "Fecha compra:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Maroon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(1317, 609);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 56);
            this.button4.TabIndex = 185;
            this.button4.Text = "Cancelar Compra";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1370, 677);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEndCompra);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1438, 716);
            this.MinimumSize = new System.Drawing.Size(1364, 716);
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosCompra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEndCompra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox codigoProducto;
        private System.Windows.Forms.TextBox talla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox descuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox precioActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox precioCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcionProducto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvProductosCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label fecha;
        public System.Windows.Forms.Label pago;
        public System.Windows.Forms.Label proveedor;
        public System.Windows.Forms.Label compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProductodgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciondgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriadgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn talladgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompradgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVentadgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidaddgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentodgv;
        private System.Windows.Forms.Button button4;
    }
}